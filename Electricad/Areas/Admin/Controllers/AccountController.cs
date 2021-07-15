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
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNet.Identity;

namespace Electricad.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        //private readonly ApplicationDbContext _context;
        private readonly IWorkContent _workContent;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public AccountController(IWebHostEnvironment hostingEnvironment, IWorkContent workContent)
        {
            _hostingEnvironment = hostingEnvironment;
            _workContent = workContent;
            //_context = context;
        }

        // GET: Login

        [HttpGet]
        public IActionResult Logintest()
        {
            return View();
        }

        

    }
}

