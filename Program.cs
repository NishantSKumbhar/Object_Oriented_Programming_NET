using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Console_OOP.Exercise;
using Console_OOP.Sample_Mobile;

namespace Console_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jay Ganesh");

            //for(int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine("Nvr Gv p");
            //}

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }
    }
}
