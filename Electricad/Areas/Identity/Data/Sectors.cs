using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Electricad.Data;
using Electricad.Models;

namespace Electricad.Data
{
    public class Sectors  
    {
        private readonly ApplicationDbContext _context;
        [Key]
        public int id { get; set; }
        public string desc { get; set; }
        public ICollection<Portfolio> Portfolios { get; set; } = new List<Portfolio>();

        public Sectors()
        {

        }

        public Sectors(int id, string desc)
        {
            this.id = id;
            this.desc = desc;
         
        }

        public ICollection<Sectors> FindAll()
        {
            return _context.tb_sectors.OrderBy(x => x.desc).ToList();
        }
    }
}
