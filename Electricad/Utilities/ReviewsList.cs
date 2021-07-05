using Electricad.Data;
using Electricad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Electricad.Utilities
{
    public class ReviewsList : Review
    {
        private readonly ApplicationDbContext _context;
        private readonly ContactForm _contact;
        public ReviewsList Review { get; set; }
        public ReviewsList(ApplicationDbContext context, ContactForm contact)
        {
            _contact = contact;
            _context = context;
        }

        public List<Review> FindAll()
        {
            return _context.tb_reviews.ToList();
        }
      

        
    }
}
