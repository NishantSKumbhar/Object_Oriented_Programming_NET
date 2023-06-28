using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.OverRiding
{
    internal class CIRCLE: SHAPE
    {
        public override void Draw()
        {
            Console.WriteLine("Circle is drawing ..");
        }
    }
}
