using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lancom.Domain
{
    public class Country
    {
        public Country()
        {
            Cities = new List<City>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        public List<City> Cities { get; set; } 
    }
}
