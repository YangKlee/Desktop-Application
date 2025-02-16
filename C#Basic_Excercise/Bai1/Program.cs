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
                      
            Console.Write("Type your name: ");
            Console.InputEncoding = Encoding.UTF8;
            String inpName = Console.ReadLine();
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Your name is {inpName}");
        }
    }
}
