using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.Exercise
{
    internal class WatchStart
    {

        private static WatchStart START = null;
        private WatchStart() { }

        public static WatchStart GetInstanceWatchStart() 
        {
            if(START == null)
            {
                START = new WatchStart();
            }
            return START;
        }

        public DateTime GetTime()
        {
            return DateTime.Now;
        }
    }
}
