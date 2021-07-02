using Electricad.Data;
using Electricad.Models;
using Electricad.Utilities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Manage.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;




namespace Electricad.Controllers
{

    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly ReviewsList _reviewList;
        private readonly ILogger<HomeController> _logger;
        private IConfiguration configuration;
        private IWebHostEnvironment webHostEnvironment;

        public HomeController(ILogger<HomeController> logger, ReviewsList reviewList,
                    ApplicationDbContext context, IConfiguration _configuration, IWebHostEnvironment _webHostEnvironment)
        {
            db = context;
            _reviewList = reviewList;
            _logger = logger;
            configuration = _configuration;
            webHostEnvironment = _webHostEnvironment;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {   
            //var list = _reviewList.FindAll();
            return View(await db.tb_reviews.ToListAsync());
        }
 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ContactForm contactForm)
        {
            if (contactForm.Subject == "2") { 
                if (ModelState.IsValid)
            {
                Review r = new Review()
                {
                    name = contactForm.Name,
                    dateComment  = DateTime.Now.ToString("MM/dd/yyyy"),
                    comment = contactForm.Content,
                };

                db.Add(r);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            }
            return View(contactForm);
        }

        [HttpPost]
        [Route("send")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Send(ContactForm contactForm, IFormFile[] attachments)
        {   //Check if the type of subject if 1 is quotation
            if (contactForm.Subject == "1")
            {
                //IFormFile[] attachments List<IFormFile> postedFiles
                var body = contactForm.Content + "<br><br> Name: " + contactForm.Name + "<br>Email: "
                + contactForm.Email + "<br>Address: " + contactForm.Address + "<br>Phone: " + contactForm.Phone + "<br>" +
                 "<br>";
                var mailHelper = new MailSender(configuration);
                List<string> fileNames = null;
                if (attachments != null && attachments.Length > 0)
                {
                    fileNames = new List<string>();
                    foreach (IFormFile attachment in attachments)
                    {
                        var path = Path.Combine(webHostEnvironment.WebRootPath, "uploads", attachment.FileName);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await attachment.CopyToAsync(stream);
                        }
                        fileNames.Add(path);
                    }
                }
                if (mailHelper.Send(contactForm.Email, configuration["Gmail:Username"], contactForm.Subject, body, fileNames))
                {
                    ViewBag.msg = "Sent Mail Successfully";
                    return View("Index", new ContactForm());

                }
                else
                {
                    ViewBag.msg = "Failed";
                }
            }
            
            return View("Index");
        }



         [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
             public IActionResult Error()
             {
                 return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
             }

         

    }
}
