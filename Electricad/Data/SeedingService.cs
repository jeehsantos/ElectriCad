using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Electricad.Models;
namespace Electricad.Data
{
    public class SeedingService
    {
        private ApplicationDbContext _context;

        public SeedingService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.tb_sectors.Any())
            {
                return; //DB Has been seeded
            }
            Sectors s1 = new Sectors(1, "Residential");
            Sectors s2 = new Sectors(2, "Commercial");
            Sectors s3 = new Sectors(3, "Switchboards");
            Sectors s4 = new Sectors(4, "Solar Panels");
            Sectors s5 = new Sectors(5, "Design");

            _context.tb_sectors.AddRange(s1, s2, s3, s4, s5);
            _context.SaveChanges();
        }
    }
}
