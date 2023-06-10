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

            S1 s = new S1(1, 3);

            s.Move(1, 3);
            try
            {
                s.Move(null);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Calculator c = new Calculator();
            int x = c.Add(1, 2, 3, 4, 5, 6);
            Console.WriteLine(x);

        }
    }
}
