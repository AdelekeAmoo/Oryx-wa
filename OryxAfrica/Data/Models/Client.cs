using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OryxAfrica.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientDesc { get; set; }
        public byte[] Image { get; set; }
    }
}
