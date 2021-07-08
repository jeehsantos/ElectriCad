﻿using Electricad.Areas.Identity.Repository;
using Electricad.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using Electricad.Models;
using System.Threading.Tasks;

namespace Electricad.Areas.Identity
{
    public class PortfolioRepository : Repository<Portfolio>, IPortfolioRepository
    {
        private readonly ApplicationDbContext _db;

        public PortfolioRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Portfolio portfolio)
        {
            var objDesdeDb = _db.tb_portifolio.FirstOrDefault(s => s.id == portfolio.id);
          
            objDesdeDb.port_file = portfolio.port_file;
            
            _db.SaveChanges();
        }
    }
}
