using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.Inheritance
{
    internal class Manager: Employee
    {
        private List<string> _powers;
        private int _allowance;

        public Manager()
        {
            Console.WriteLine("Default Manager");
        }

        public Manager(int id, int age, string name, string email, int salary, List<string> powers, int allowance): base(id, age, name, email, salary)
        {
            _powers = powers;
            _allowance = allowance;
        }

        public void show()
        {
            Console.WriteLine(this._salary);
            Console.WriteLine(this._powers);
            Console.WriteLine(this._allowance);
        }
    }
}
