using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Electricad.Data
{
    public class Portfolio  
    {

        [Key]
        public int id { get; set; }
        public string port_file { get; set; }
        [ForeignKey("sector_id")]
        public User User { get; set; }
       public Sectors Sector { get; set; }
        public int SectorsId { get; set; }

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
