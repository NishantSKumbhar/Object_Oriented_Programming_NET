using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Console_OOP.Exercise;
using Console_OOP.Sample_Mobile;
using Console_OOP.Mosh_EX_1;
//using Console_OOP.Composition;
using Console_OOP.Mosh_EX_2;
using Console_OOP.Inheritance;
using Console_OOP.Mosh_EX_3_Stack;
using Console_OOP.OverRiding;
using Console_OOP.Mosh_EX_4_Abstract;
using Console_OOP.Interface;


namespace Console_OOP
{
    internal class Program
    {
        class Class1
        {
            public int id { get; set; }

            string _name;
            public string name
            {
                get { return _name; }
                set { _name = value; }
            }
        }
        static void Main(string[] args)
        {

           
            Console.WriteLine("Jay Ganesh");
            Class1 c = new Class1();
            c.id = 1;
            c.name = "test";
            Console.WriteLine(c.id + " " + c.name);
            Console.ReadLine();
            
        }
    }
}
