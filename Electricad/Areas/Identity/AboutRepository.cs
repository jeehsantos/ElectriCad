using Electricad.Areas.Identity.Repository;
using Electricad.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using Electricad.Models;
using System.Threading.Tasks;

namespace Electricad.Areas.Identity
{
    public class AboutRepository : Repository<About>, IAboutRepository
    {
        private readonly ApplicationDbContext _db;

        public AboutRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(About about)
        {
            var objDesdeDb = _db.tb_about.FirstOrDefault(s => s.Userid == about.Userid);
            objDesdeDb.about_desc = about.about_desc;
            objDesdeDb.about_file = about.about_file;
            _db.SaveChanges();
        }
    }
}
