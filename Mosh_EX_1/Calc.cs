using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.Mosh_EX_1
{
    internal class Calc
    {
        private static Calc c = null;
        DateTime st;
        private Calc() { }

        public static Calc GetCalcInstance()
        {
            if(c == null) 
            { 
                c = new Calc();
            }
            return c;
        }
       
        StartT str = null;
        StopT stp = new StopT();
        public void Start()
        {
            if(str == null)
            {
                str = new StartT();
                Console.WriteLine("Watch Started");
                stp = null;
            }
            else
            {
                throw new InvalidOperationException("Instance already assigned, Watch already Started !");
            }
        }

        public void Stop()
        {
            if (stp == null)
            {
                stp = new StopT();
                Console.WriteLine("Watch Stopped !");
                st = str.StartTime;
                str = null;
            }
            else
            {
                throw new InvalidOperationException("Instance already assigned, Watch already Stopped !");
            }
        }

        public void GetDuration()
        {
            if(str == null && stp != null)
            {
                TimeSpan t = st - stp.StopTime;
                Console.WriteLine("Duration : " + t);
            }
            else
            {
                throw new InvalidOperationException("Watch has to be stopped!");
            }
        }
    }
}
