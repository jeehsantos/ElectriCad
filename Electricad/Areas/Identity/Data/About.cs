using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Electricad.Data;
using Electricad.Models;
using Microsoft.EntityFrameworkCore;

namespace Electricad.Data
{ 
    public class About  
    {
        [Key]
        [ForeignKey("User")]
        public int Userid { get; set; }
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Image")]
        public string about_file { get; set; }
        [Required(ErrorMessage = "A description is required")]
        [Display(Name = "Your profile description")]
        public string about_desc { get; set; }
        public User User { get; set; }

        public About()
        {

        }

        public About(int id, string about_file, string about_desc)
        {
            this.Userid = id;
            this.about_file = about_file;
            this.about_desc = about_desc;
         
        }
 

    } 
}
