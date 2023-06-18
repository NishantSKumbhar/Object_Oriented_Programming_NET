using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.OverRiding
{
    internal class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("BaseClass");
        }

        public  void Add(int n1, int n2, int n3)
        {
            Console.WriteLine("In the BaseClass Add");
            int ans = n1 + n2 + n3;
            Console.WriteLine(ans);
        }
    }
}
