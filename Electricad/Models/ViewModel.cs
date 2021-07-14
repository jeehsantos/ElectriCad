using Electricad.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Electricad.Models
{
    public class ViewModel
    {
        public List<Portfolio> Portfolio { get; set; }
        public About About { get; set; }
        public List<Offers> Offers { get; set; }
        public List<User> Users { get; set; }
        public List<Review> Reviews { get; set; }
        public ContactForm Forms { get; set; }
    }
}
