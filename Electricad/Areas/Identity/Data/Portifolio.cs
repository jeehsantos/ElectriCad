using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Electricad.Data
{
    public class Portfolio  
    {

        [Key]
        public int id { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Image")]
        public string port_file { get; set; }
      
        public User User { get; set; }
        public ICollection<Sectors> Sector { get; set; }
        [ForeignKey("sector_id")]
        public int sector_id { get; set; }

        public Portfolio()
        {

        }

        public Portfolio(int id, string port_file)
        {
            this.id = id;
            this.port_file = port_file;
            
        }
 
    }
}
