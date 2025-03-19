using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.showData();
            Employee obj1 = new Employee("Shikanoko", 2);
            obj1.showData();

        }
    }
}
