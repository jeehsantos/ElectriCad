using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Electricad.Data;
using Electricad.Models;

namespace Electricad.Data
{
    public class About  
    {

        [Key]
        public int id { get; set; }
        
        [Display(Name = "About image")]
        public string about_file { get; set; }
     
        [Display(Name = "About Description")]
        public string about_desc { get; set; }
        [ForeignKey("user_id")]
        public int Userid { get; set; }
        public User User { get; set; }

        public About()
        {

        }

        public About(int id, string about_file, string about_desc, User user)
        {
            this.id = id;
            this.about_file = about_file;
            this.about_desc = about_desc;
            this.User = user;
        }
 

    } 
}
