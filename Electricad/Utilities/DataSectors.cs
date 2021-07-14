using Electricad.Areas.Identity;
using Electricad.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Electricad.Models
{
    public class DataSectors : Sectors
    {
        private readonly ApplicationDbContext _context;

        public DataSectors(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Sectors> FindAll()
        {
            return _context.tb_sectors.OrderBy(x => x.desc).ToList();
        }
    }
}
