using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Program
    {
        static bool isPrime(int n)
        {
            if (n < 2) return false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("First 10 prime number is: ");
            int count = 0, i = 2;
            while (count < 10)
            {
                if (isPrime(i))
                {
                    Console.WriteLine($"So nguyen to thu {count +1} la: {i}");
                    count++;
                }
                i++;
            }
        }
    }
}
