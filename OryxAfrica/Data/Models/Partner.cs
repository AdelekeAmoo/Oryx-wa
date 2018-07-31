using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OryxAfrica.Models
{
    public class Partner
    {
        public Partner() { }

        public int PartnerID { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public string ImageSourceFileName { get; set; }
        public string ImageContentType { get; set; }
        public string Details { get; set; }


    }
}
