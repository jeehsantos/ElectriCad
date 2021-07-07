using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Electricad.Areas.Identity.Repository
{
    public interface IWorkContent : IDisposable
    {
       /// ICategoriaRepository Categoria { get; }
    //IArticuloRepository Articulo { get; }
    IOffersRepository Offers { get; }
    IAboutRepository About { get; }

    void Save();
    }
}
