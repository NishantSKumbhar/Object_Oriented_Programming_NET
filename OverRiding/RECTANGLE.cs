using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.OverRiding
{
    internal class RECTANGLE: SHAPE
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle is drawing...");
        }
    }
}
