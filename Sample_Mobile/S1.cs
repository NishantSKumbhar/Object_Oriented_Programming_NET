using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.Sample_Mobile
{
    internal class S1
    {
        int x;
        int y;

        public S1(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(S1 s)
        {   
            if (s == null)
            {
                throw new ArgumentNullException("Argument can not be null");
            }
            Move(s.x, s.y);
        }
    }
}
