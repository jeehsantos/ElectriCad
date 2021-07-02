using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int descount { get; set; }
        public string offer_file { get; set; }
        public string desc { get; set; }
        public User User { get; set; }

        public Offers()
        {

        }

        public Offers(int id, int descount, string offer_file, string desc)
        {
            this.id = id;
            this.descount = descount;
            this.offer_file = offer_file;
            this.desc = desc;
        }
    }
}
