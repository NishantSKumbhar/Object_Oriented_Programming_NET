using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.Mosh_EX_3_Stack
{
    internal class Stack
    {
        private List<Object> stack = new List<Object>();
        public void push(Object obj)
        {
            if(obj == null)
            {
                throw new InvalidOperationException("Object can not be null !");
            }
            stack.Add(obj);
            Console.WriteLine("Successfully added to stack.");
        }

        public void pop()
        {
            if(stack.Count < 1)
            {
                throw new InvalidOperationException("Stack is Empty !");
            }
            stack.RemoveAt(stack.Count - 1);
            Console.WriteLine("Successfully removed from stack  : " + stack[stack.Count - 1]);
        }

        public void ShowStack()
        {
            if(stack.Count > 0)
            {
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void Clear()
        {
            stack.Clear();
            Console.WriteLine("Stack Cleaed !");
        }
    }
}
