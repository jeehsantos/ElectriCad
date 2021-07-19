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
using Electricad.Models;
using Microsoft.AspNetCore.Authorization;

namespace Electricad.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class PortfolioController : Controller
    {
        //private readonly ApplicationDbContext _context;
        private readonly IWorkContent _workContent;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly DataSectors _sectors;

        public ApplicationDbContext Db { get; }
 

        public PortfolioController(ApplicationDbContext db, IWebHostEnvironment hostingEnvironment, IWorkContent workContent, DataSectors sectors)
        { 
            _hostingEnvironment = hostingEnvironment;
            _workContent = workContent;
            _sectors = sectors;
            Db = db;
           
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
            var z = new ViewModel();
            
            z.Sectors = _sectors.FindAll();
           
            return View(z);
        }

        // POST: Offers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Portfolio portfolio)
        {
            if (ModelState.IsValid)
            {
                string principalRoot = _hostingEnvironment.WebRootPath;
                var archivos = HttpContext.Request.Form.Files;

                // new article
                string fileName = Guid.NewGuid().ToString();
                var uploads = Path.Combine(principalRoot, @"Uploads\portfolio");
                var extension = Path.GetExtension(archivos[0].FileName);

                using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                {
                    archivos[0].CopyTo(fileStreams);
                }
                portfolio.port_file = @"/Uploads/portfolio/" + fileName + extension;

                _workContent.Portfolio.Add(portfolio);
                _workContent.Save();

                return RedirectToAction(nameof(Index));

            }
            return RedirectToAction(nameof(Index));
        }

        #region CALLING THE API
        [HttpGet]
        public IActionResult GetAll()
        { 
            var labelPortfolio = (from p in Db.tb_portifolio
                              join e in Db.tb_sectors
                              on p.Sectorsid equals e.id
                             
                              select new
                              {
                                  id = p.id,
                                  port_file = p.port_file,
                                  desc = e.desc

                              }).ToList();

            return Json(new { data = labelPortfolio });
        }



        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _workContent.Portfolio.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error to delete image" });
            }
            _workContent.Portfolio.Remove(objFromDb);
            _workContent.Save();
            return Json(new { success = true, message = "Image deleted successfully !" });
        }
        #endregion
    }
}

