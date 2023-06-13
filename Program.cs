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


namespace Console_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

			try
			{
				Stack stack = new Stack();
				stack.push(1);
				stack.push(2);
				stack.push(3);

				stack.ShowStack();

				stack.pop();
				stack.pop();

				stack.ShowStack();
				stack.Clear();
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}
        }
    }
}
