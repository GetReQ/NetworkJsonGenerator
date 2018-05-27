using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkGenerator
{
    class Network
    {
        public IEnumerable<Section> Sections { get; set; }
        public IEnumerable<Asset> Assets { get; set; }
    }
}
