using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OryxAfrica.Models
{
    public class Career
    {
        [Key]
        public int CareerID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
