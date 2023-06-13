using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_OOP.Inheritance
{
    internal class Employee
    {
        private int _id;
        private int _age;
        private string _name;
        private string _email;
        protected int _salary;
        public Employee()
        {
            Console.WriteLine("Default Employee");
        }

        public Employee(int id, int age, string name, string email, int salary)
        {
            this._name = name;
            this._id = id;
            this._age = age;
            this._email = email;
            this._salary = salary;
        }

        public void DoProject()
        {
            Console.WriteLine("Employee Doing the Project");
        }
        public void show()
        {
            Console.WriteLine(this._id);
            Console.WriteLine(this._name);
            Console.WriteLine(this._age);
            Console.WriteLine(this._email);
            Console.WriteLine(this._salary);
        }

    }
}
