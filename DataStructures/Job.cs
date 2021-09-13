using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Job
    {
        public int id { get; set; }
        public int profit { get; set; }
        public int deadline { get; set; }

        public Job(int id, int deadline, int profit)
        {
            this.id = id;
            this.profit = profit;
            this.deadline = deadline;
        }
    }
}
