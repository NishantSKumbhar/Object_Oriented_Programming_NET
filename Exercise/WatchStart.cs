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


//StopWatch s = StopWatch.getStpInstance();

//s.StartTheWatch();
//Thread.Sleep(10000);
//s.StopTheWatch();
//s.GetTheDuration();

//int Choice = 0;

//do
//{
//    Console.WriteLine("Choice 1 : To Start the Watch.");
//    Console.WriteLine("Choice 2 : To Stop the Watch.");
//    Console.WriteLine("Choice 3 : To Get Duration.");
//    Console.WriteLine("Choice 4 : EXIT.");
//    Console.WriteLine("Enter the Choice : ");
//    Choice = Convert.ToInt32(Console.ReadLine());
//    Console.Clear();
//    Console.WriteLine("\n\n-------------------------------------------------");
//    switch (Choice)
//    {
//        case 1:
//            s.StartTheWatch();
//            break;
//        case 2:
//            s.StopTheWatch();
//            break;
//        case 3:
//            s.GetTheDuration();
//            break;
//        default:
//            Console.WriteLine("Thank you.");
//            break;
//    }
//    Console.WriteLine("\n\n-------------------------------------------------");
//} while (Choice != 4);