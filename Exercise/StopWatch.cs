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
        WatchStart w = WatchStart.GetInstanceWatchStart();

        private  DateTime start;
        private  DateTime stop;
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
            //Console.WriteLine("Watch Started ...");
            
            if(w == null )
            {
                Console.WriteLine("Watch Started ...");
                w = WatchStart.GetInstanceWatchStart();
                start = w.GetTime();
            }
            else
            {
                Console.WriteLine("Watch already Started ...");
            }
        }

        public void StopTheWatch()
        {
            Console.WriteLine("Watch Stopped ...");
            w = null;
        }

        public void GetTheDuration()
        {
            Console.WriteLine("Duration : ");
        }


    }
}
