using Electricad.Data;
using Electricad.Models;
using Electricad.Utilities;
using Microsoft.AspNetCore.Authorization;
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
using System.Reactive;
using System.Threading.Tasks;




namespace Electricad.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly ContactForm _contactForm;
        private readonly ILogger<HomeController> _logger;
        private IConfiguration configuration;
        private IWebHostEnvironment webHostEnvironment;

        public ContactForm Contact { get; set; }
        public HomeController(ILogger<HomeController> logger, ContactForm contactForm,
                    ApplicationDbContext context, IConfiguration _configuration, IWebHostEnvironment _webHostEnvironment)
        {
            db = context;
            _contactForm = contactForm;
            _logger = logger;
            configuration = _configuration;
            webHostEnvironment = _webHostEnvironment;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var z = new ViewModel();
            z.Forms = new ContactForm();
            z.Reviews = db.tb_reviews.ToList();
           var Movies = (from id in db.tb_about select id).FirstOrDefault();
            z.About = new About(); 
            z.About = Movies;
            z.Offers = db.tb_offers.ToList();
            return View(z);
        }

        [HttpPost]
        public async Task<IActionResult> Index(ViewModel contact, IFormFile[] attachments)
        {
            if (contact.Forms.Subject == "2")
            {
                if (ModelState.IsValid)
                {
                    Review r = new Review()
                    {
                        name = @contact.Forms.Name,
                        dateComment = DateTime.Now.ToString("MM/dd/yyyy"),
                        comment = @contact.Forms.Content,
                    };
                    db.Add(r);
                    await db.SaveChangesAsync();
                    var m = new ViewModel();
                    m.Forms = new ContactForm();
                    m.Reviews = db.tb_reviews.ToList();
                    m.Offers = db.tb_offers.ToList();
                    ModelState.Clear();
                    TempData["Msg"] = "Review sent successfully";
                    return View(m);
                }
            }
            else
            {
                //IFormFile[] attachments List<IFormFile> postedFiles
                var body = @contact.Forms.Content + "<br><br> Name: " + @contact.Forms.Name + "<br>Email: "
                + @contact.Forms.Email + "<br>Address: " + @contact.Forms.Address + "<br>Phone: " + @contact.Forms.Phone + "<br>" +
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
                if (mailHelper.Send(@contact.Forms.Email, configuration["Gmail:Username"], @contact.Forms.Subject, body, fileNames))
                {
                    ViewBag.msg = "Sent Mail Successfully";
                    var b = new ViewModel();
                    b.Forms = new ContactForm();
                    b.Reviews = db.tb_reviews.ToList();
                    ModelState.Clear();
                    TempData["Msg"] = "Email sent successfully";
                    return View(b);
                }
                else
                {
                    ViewBag.msg = "Failed";
                }
            }
            var z = new ViewModel();
            z.Forms = new ContactForm();
            z.Reviews = db.tb_reviews.ToList();
            ModelState.Clear();

            return View(z);
        }
    
         [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
             public IActionResult Error()
             {
                 return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
             }
    }
}
