using Electricad.Data;
using Electricad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Electricad.Utilities
{
    public class ReviewsList 
    {
        private readonly ApplicationDbContext _context;
        public ReviewsList Review { get; set; }
        public ReviewsList(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Review> FindAll()
        {
            return _context.tb_reviews.ToList();
        }
      

        
    }
}
