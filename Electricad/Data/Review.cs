using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Electricad.Data;
using Electricad.Models;

namespace Electricad.Data
{
    public class Review  
    {

        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string comment { get; set; }
        public string dateComment { get; set; }
     
        public Review()
        {

        }

        public Review(int id, string name, string comment, string dateComment)
        {
            this.id = id;
            this.name = name;
            this.comment = comment;
            this.dateComment = dateComment;
        }
    }
    /*
    public class FormFields
    {
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Subject { get; set; }
        public string Content { get; set; }
    }

    public class ViewModel
    {
        public IEnumerable<Review> tb_reviews { get; set; }
        public IEnumerable<FormFields> Form { get; set; }
    }*/
}
