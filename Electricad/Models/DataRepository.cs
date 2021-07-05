using Electricad.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Electricad.Models
{
    public class DataRepository
    {
        public List<Review> GetAllReviews()
        {
            return new List<Review> {
                new Review { comment = "Ok", dateComment = "10/10/10",
                    id = 1, name = " me" }
            };
        }
        public List<ContactForm> GetForm()
        {
            return new List<ContactForm> {
               new ContactForm { Name = "", Address = "", Content = "",
            Email = "", Phone = "", Subject= ""
            }
        };
            //List<>
        }
    }
}
