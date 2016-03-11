using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Scheduling
{
    public class BlockData
    {
        public int arrival;
        public int index;
        public int burst_time;
        public int priority;

        public BlockData()
        {

        }
        public BlockData(int i,int value,int b)
        { 
            index =i;
            arrival = value;
            burst_time = b;
        }

        public BlockData(int i,int value,int b,int p)
        { 
            index =i;
            arrival = value;
            burst_time = b;
            priority = p;
        }

        
    }
}
