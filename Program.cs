using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Console_OOP.Exercise;
using Console_OOP.Sample_Mobile;
using Console_OOP.Mosh_EX_1;
using Console_OOP.Composition;
using Console_OOP.Mosh_EX_2;
using Console_OOP.Inheritance;
using Console_OOP.Mosh_EX_3_Stack;
using Console_OOP.OverRiding;

namespace Console_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass b = new BaseClass();
            b.Add(1, 2, 3);

            DerivedClass d = new DerivedClass();
            d.Add(3, 4, 12);
			
        }
    }
}
