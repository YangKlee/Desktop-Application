using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace InterpolatedExample
{
    internal class Test
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a, b;
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Kết quả {a} + {b} là: {a+b}");
        }
    }
}
