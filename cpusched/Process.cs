using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpusched
{
    class Process
    {
        public string Name {get; set; }
        public double Arrival {get; set; }
        public int Burst {get; set; }
    }
}
