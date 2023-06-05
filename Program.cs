using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Console_OOP.Exercise;


namespace Console_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jay Ganesh");

            StopWatch s = StopWatch.getStpInstance();

            s.StartTheWatch();
            s.StopTheWatch();
            s.GetTheDuration();

        }
    }
}
