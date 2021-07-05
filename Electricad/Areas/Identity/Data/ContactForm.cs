using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Mail;
using Electricad.Data;
using System.Collections;

namespace Electricad.Models
{
    public  class ContactForm  
    {
        [Required(ErrorMessage = " The field Name is required")]
        public  string? Name { get; set; }

         public  string Phone { get; set; }
        [Required(ErrorMessage = " The field Email is required")]
        public  string? Email { get; set; }

         public  string Address { get; set; }
         
         public  string Subject { get; set; }
         [Required(ErrorMessage = " The field Content is required")]
         public  string? Content { get; set; }

        

    }
}
