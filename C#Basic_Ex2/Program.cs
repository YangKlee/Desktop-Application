using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic_Ex2
{
    public  class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Enter number 1 - 3");
            String strInp = Console.ReadLine();
            switch (strInp)
            {
                case "1":
                    Console.WriteLine("First day of week is Sunday"); break;
                case "2":
                    Console.WriteLine("Second day of week is Monday"); break;
                case "3":
                    Console.WriteLine("Third day of week is Tuesday"); break;
                default:
                    Console.WriteLine("Enter again"); break;
                    
            }
        }
    }
}
