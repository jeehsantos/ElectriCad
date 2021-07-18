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
    public class Offers  
    {

        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Type a discount %")]
        [Display(Name = "Discount %")]
        public int discount { get; set; }
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Image")]
        public string offer_file { get; set; }
        [Required(ErrorMessage = "Type a name for the slider")]
        [Display(Name = "Slider Name")]
        public string desc { get; set; }
        public User User { get; set; }

        public Offers()
        {

        }

        public Offers(int id, int discount, string offer_file, string desc)
        {
            this.id = id;
            this.discount = discount;
            this.offer_file = offer_file;
            this.desc = desc;
        }
    }
}
