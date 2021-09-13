using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Item
    {
        public int value { get; set; }
        public int weight { get; set; }

        public Item(int value, int weight)
        {
            this.value = value;
            this.weight = weight;
        }
    }
}
