using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.OverRiding
{
    internal abstract class SHAPE
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public abstract void Draw();
    }
}
