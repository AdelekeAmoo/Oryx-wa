using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OryxAfrica.Models
{
    public class Solution
    {
        public int SolutionId { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public byte[] Image { get; set; }
        public string Link { get; set; }
    }
}
