using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoDep
{
    /*
     * Một số được coi là đẹp nếu nó là số thuận nghịch, tổng chữ số là số nguyên tố và tất cả các chữ số đều lẻ.
     */
    internal class Program
    {
        static bool isThuanNghich(int n)
        {
            int first_num = n;
            int reverse = 0;
            while (n > 0)
            {
                reverse = reverse * 10 + n % 10;
                n /= 10;
            }
            if (reverse == first_num)
                return true;
            return false;
        }
        static bool isPrime(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static bool isPrimeAndElven(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                if ((n % 10) % 2 == 0)
                    return false;
                sum += (n % 10);
                n /= 10;
            }
            if (isPrime(sum))
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            int a, b, count = 0;
            a = Int16.Parse(Console.ReadLine());
            b = Int16.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (isPrimeAndElven(i) && isThuanNghich(i))
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
