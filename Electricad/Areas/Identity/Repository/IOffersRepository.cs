using Electricad.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Electricad.Areas.Identity.Repository
{
    public interface IOffersRepository : IRepository<Offers>
    {
        void Update(Offers offers);
    }
}
