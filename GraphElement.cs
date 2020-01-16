using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIMP2
{
    class GraphElement
    {
        public List<GraphElement> ListElements { get; set; };
        public bool Visited { get; set; }
    }
}
