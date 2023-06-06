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
            Mobile m = new Mobile();
            m.Price= 100;
            m.Description = "kjs99 23 9- 2-2-2-2-2";
            m.Name = "Note 1";
            m.show();           
        }
    }
}
