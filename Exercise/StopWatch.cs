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
       
        
        private  DateTime start;
        private  DateTime stop;
        WatchStart w = WatchStart.GetInstanceWatchStart();
        private bool Started = false;

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
            if (Started)
            {
                Console.WriteLine("Sorry, Already Started...");
            }
            else
            {
                Console.WriteLine("Watch Started ...");
                start = w.GetTime();
                Started = true;
            }
        }

        public void StopTheWatch()
        {
            if (!Started)
            {
                Console.WriteLine("Sorry , Already Stopped...");
            }
            else
            {
                Console.WriteLine("Watch Stopped ...");
                stop = w.GetTime();
                Started = false;
            }
        }

        public void GetTheDuration()
        {
            //Console.WriteLine("Duration : ");
            if(Started)
            {
                Console.WriteLine("Please, stop the Watch to get the Duration.");
            }
            else
            {
                TimeSpan t = start - stop;
                Console.WriteLine("Duration : "+ t);
            }

        }


    }
}
