using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Please input a number (1 - 7): ");
                int inp = Int16.Parse(Console.ReadLine());
                switch (inp)
                {
                    case 1: Console.WriteLine("First day of week is Sunday"); break;
                    case 2: Console.WriteLine("Second day of week is Monday"); break;
                    case 3: Console.WriteLine("Third day of week is Tuesday"); break;
                    case 4: Console.WriteLine("Fourth day of week is Wednesday"); break;
                    case 5: Console.WriteLine("Firth day of week is Thusday"); break;
                    case 6: Console.WriteLine("Sixth day of week is Friday"); break;
                    case 7: Console.WriteLine("Seventh day of week is Saturday"); break;
                    default: Console.WriteLine("Please input a number (1 - 7)"); break;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Input false! Please try again\nCode error: " + ex.Message);
            }
            
        }
    }
}
