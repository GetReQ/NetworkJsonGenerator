using System.Collections.Generic;

namespace NetworkGenerator
{
    class Network
    {
        public IEnumerable<Section> Sections { get; set; }
        public IEnumerable<Asset> Assets { get; set; }
    }
}
