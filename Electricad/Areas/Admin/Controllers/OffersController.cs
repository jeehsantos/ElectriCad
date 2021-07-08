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
    public class OffersController : Controller
    {
        //private readonly ApplicationDbContext _context;
        private readonly IWorkContent _workContent;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public OffersController( IWebHostEnvironment hostingEnvironment, IWorkContent workContent)
        {
            _hostingEnvironment = hostingEnvironment;
            _workContent = workContent;
            //_context = context;
        }

        // GET: Offers
      
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        } 


        // GET: Offers/Create se nao esta comentado o codigo e porque estava igual o outro
        public IActionResult Create()
        {
            return View();
        }

        // POST: Offers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Offers Offers)
        {
            if (ModelState.IsValid)
            {
                string rutaPrincipal = _hostingEnvironment.WebRootPath;
                var archivos = HttpContext.Request.Form.Files;

                // new article
                string nombreArchivo = Guid.NewGuid().ToString();
                var subidas = Path.Combine(rutaPrincipal, @"Uploads\sliders");
                var extension = Path.GetExtension(archivos[0].FileName);

                using (var fileStreams = new FileStream(Path.Combine(subidas, nombreArchivo + extension), FileMode.Create))
                {
                    archivos[0].CopyTo(fileStreams);
                }
                Offers.offer_file = @"\Uploads\sliders\" + nombreArchivo + extension;

                _workContent.Offers.Add(Offers);
                _workContent.Save();

                return RedirectToAction(nameof(Index));

            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Offers/Edit/5
        [HttpGet]
        public IActionResult Edit(int? id)
        {

            if (id != null)
            {
                var slider = _workContent.Offers.Get(id.GetValueOrDefault());
                return View(slider);
            }

            return View();
        }

        // POST: Offers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Offers offers)
        {
            if (ModelState.IsValid)
            {
                string mainRoot = _hostingEnvironment.WebRootPath;
                var archivos = HttpContext.Request.Form.Files;
                var sliderFromDb = _workContent.Offers.Get(offers.id);
                if (archivos.Count() > 0)
                {
                    // edit image
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(mainRoot, @"Uploads\sliders");
                    var newExtension = Path.GetExtension(archivos[0].FileName);

                    var imageRoot = Path.Combine(mainRoot, sliderFromDb.offer_file.TrimStart('\\'));


                    if (System.IO.File.Exists(imageRoot))
                    {
                        System.IO.File.Delete(imageRoot);
                    }

                    //upload again the article
                    using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + newExtension), FileMode.Create))
                    {
                        archivos[0].CopyTo(fileStreams);
                    }
                    offers.offer_file = @"\Uploads\sliders\" + fileName + newExtension;

                    _workContent.Offers.Update(offers);
                    _workContent.Save();

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    //When the image already exist and does not replace to keep the one already in the database
                    offers.offer_file = sliderFromDb.offer_file;

                }
                _workContent.Offers.Update(offers);
                _workContent.Save();

                return RedirectToAction(nameof(Index));
            }
            return View();
        }
 
      
        #region CALLING THE API
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _workContent.Offers.GetAll() });
        }



        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _workContent.Offers.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error to delete image" });
            }
            _workContent.Offers.Remove(objFromDb);
            _workContent.Save();
            return Json(new { success = true, message = "Image deleted successfully !" });
        }
        #endregion
    }
}

