using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Mail;
using Electricad.Data;
namespace Electricad.Models
{
    public  class ContactForm  
    {

         public  string Name { get; set; }

         public  string Phone { get; set; }

         public  string Email { get; set; }

         public  string Address { get; set; }
         [Required]
         public  string Subject { get; set; }
         [Required]
         public  string Content { get; set; }

        
    }
}
