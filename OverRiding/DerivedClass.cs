using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.OverRiding
{
    internal class DerivedClass: BaseClass
    {
        public DerivedClass()
        {
            Console.WriteLine("Derived Class");
        }

        public  void Add(int n1, int n2)
        {
            Console.WriteLine("In the Derived Add");
            int ans = n1 + n2;
            Console.WriteLine(ans);
        }
    }
}
