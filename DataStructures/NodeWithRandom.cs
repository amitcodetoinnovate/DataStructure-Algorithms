using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class NodeWithRandom
    {
        public int val { get; set; }
        public NodeWithRandom next { get; set; }
        public NodeWithRandom random { get; set; }

        public NodeWithRandom(int val)
        {
            this.val = val;
        }
    }
}
