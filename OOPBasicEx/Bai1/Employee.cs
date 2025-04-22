using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Employee
    {
        private string name { get; set; }
        private int age { get; set; }
        public Employee()
        {
            this.name = "Mark";
            this.age = 25;
        }
        public Employee(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void showData()
        {
            Console.WriteLine("Name = " + name);
            Console.WriteLine("Age = " + age);
        }
    }
}
