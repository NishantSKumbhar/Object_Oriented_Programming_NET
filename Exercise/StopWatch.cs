using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.Exercise
{
    internal class StopWatch
    {
        private static StopWatch stp = null;
        
        
        private DateTime start;
        private DateTime stop;
        private StopWatch() { }

        public static StopWatch getStpInstance()
        {
            if( stp == null )
            {
                stp = new StopWatch();
            }
            return stp;
        }

        public void StartTheWatch()
        {
           
            
        }

        public void StopTheWatch()
        {
            
        }


    }
}
