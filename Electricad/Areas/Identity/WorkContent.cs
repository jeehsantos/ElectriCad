using Electricad.Areas.Identity.Repository;
using Electricad.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Electricad.Areas.Identity
{
   public class WorkContent : IWorkContent
    {

        private readonly ApplicationDbContext _db;


    public WorkContent(ApplicationDbContext db)
    {
        _db = db;
       // Categoria = new CategoriaRepository(_db);
       // Articulo = new ArticuloRepository(_db);
        Offers = new OffersRepository(_db);


    }
    //public ICategoriaRepository Categoria { get; private set; }
    //public IArticuloRepository Articulo { get; private set; }
    public IOffersRepository Offers { get; private set; }

    public void Dispose()
    {
        _db.Dispose();
    }

    public void Save()
    {
        _db.SaveChanges();
    }
}
}
