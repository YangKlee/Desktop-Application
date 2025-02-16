using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int i = 10;
            while (i > 0)
            {
                Console.WriteLine(n);
                n += 5;
                i--;
            }
        }
    }
}
