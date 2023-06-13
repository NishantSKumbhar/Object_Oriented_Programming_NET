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

namespace Console_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee(1, 23, "John", "john123@gmail.com", 60000);
            e1.show();
            Console.WriteLine("--------------------");
            Manager m1 = new Manager(1, 23, "John", "john123@gmail.com", 60000, new List<string>(), 981288);
            m1.show();
            Console.WriteLine("--------------------");


            Manager m2 = new Manager();
            Employee e2 = m2;
            e2.DoProject();

            Manager m3 = (Manager)e2;
            m3.DoProject();
            m3.AssignProject();
        }
    }
}
