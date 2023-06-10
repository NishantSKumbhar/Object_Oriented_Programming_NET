using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.Sample_Mobile
{
    internal class Person
    {
        public DateTime Birthdate { get; set; }

        public int Age
        {
            get
            {
                TimeSpan t = DateTime.Now - Birthdate;
                int years  = t.Days / 365;
                return years;
            }
        }
    }
}
