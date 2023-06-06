using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.Sample_Mobile
{
    internal class Mobile
    {

        public int Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Mobile()
        {
            Console.WriteLine("Inside the Mobile Default Constructor.");
        }

        public void show()
        {
            Console.WriteLine(this.Name+ " " + this.Description + " Price : " + this.Price);
        }

    }
}
