using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SumLib;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SumLib.Class1 c = new SumLib.Class1();
            Console.WriteLine(c.Sum(3 , 2));
        }
    }
}
