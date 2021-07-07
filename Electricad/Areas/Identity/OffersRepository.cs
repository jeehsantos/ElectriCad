using Electricad.Areas.Identity.Repository;
using Electricad.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using Electricad.Models;
using System.Threading.Tasks;

namespace Electricad.Areas.Identity
{
    public class OffersRepository : Repository<Offers>, IOffersRepository
    {
        private readonly ApplicationDbContext _db;

        public OffersRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Offers offers)
        {
            var objDesdeDb = _db.tb_offers.FirstOrDefault(s => s.id == offers.id);
            objDesdeDb.desc = offers.desc;
            objDesdeDb.descount = offers.descount;
            objDesdeDb.offer_file = offers.offer_file;
            _db.SaveChanges();
        }
    }
}
