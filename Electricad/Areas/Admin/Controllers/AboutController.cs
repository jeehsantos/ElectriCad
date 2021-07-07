using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Electricad.Data;
using Electricad.Areas.Identity.Repository;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Electricad.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWorkContent _workContent;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public AboutController(ApplicationDbContext context, IWebHostEnvironment hostingEnvironment, IWorkContent workContent)
        {
            _hostingEnvironment = hostingEnvironment;
            _workContent = workContent;
            _context = context;
        }

        // GET: About
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        } 

        // GET: About/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            id = 1;
            if (id == null)
            {
                return NotFound();
            }

            var about = await _context.tb_about
                .FirstOrDefaultAsync(m => m.id == id);
            if (about == null)
            {
                return NotFound();
            }

            return View(about);
        }

        

        // GET: About/Edit/5
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            id = 1;

            if (id != null)
            {
                var about = _workContent.About.Get(id.GetValueOrDefault());
                return View(about);
            }

            return View();
        }

        // POST: About/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(About about)
        {
            if (ModelState.IsValid)
            {
                string mainRoot = _hostingEnvironment.WebRootPath;
                var archivos = HttpContext.Request.Form.Files;
                var aboutFromDb = _workContent.About.Get(about.id);
                if (archivos.Count() > 0)
                {
                    // edit image
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(mainRoot, @"Uploads\about");
                    var newExtension = Path.GetExtension(archivos[0].FileName);

                    var imageRoot = Path.Combine(mainRoot, aboutFromDb.about_file.TrimStart('\\'));


                    if (System.IO.File.Exists(imageRoot))
                    {
                        System.IO.File.Delete(imageRoot);
                    }

                    //upload again the article
                    using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + newExtension), FileMode.Create))
                    {
                        archivos[0].CopyTo(fileStreams);
                    }
                    about.about_file = @"\Uploads\about\" + fileName + newExtension;

                    _workContent.About.Update(about);
                    _workContent.Save();

                    return RedirectToAction(nameof(Details));
                }
                else
                {
                    //When the image already exist and does not replace to keep the one already in the database
                    about.about_file =aboutFromDb.about_file;

                }
                _workContent.About.Update(about);
                _workContent.Save();

                return RedirectToAction(nameof(Details));
            }
            return View();
        }
 
       
    }
}

