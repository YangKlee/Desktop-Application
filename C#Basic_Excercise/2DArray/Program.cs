using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray
{

    internal class Program
    {
         static void inputArr(int[,] a, out int m, out int n)
        {
            m = n = -1;
            try
            {
                Console.Write("Nhap so hang cua mang: ");
                m = Int16.Parse(Console.ReadLine());
                Console.Write("Nhap so cot cua mang: ");
                n = Int16.Parse(Console.ReadLine());
                
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"A[{i}][{j}] = ");
                        a[i,j] = Int16.Parse(Console.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                m = n = -1;
            }
        }
        static void displayArr(int[,] a, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", a[i,j]);

                }
                Console.Write("\n");
            }    
        }
        static int sumOfArr(int[,] a, int m, int n)
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum += a[i, j];

                }
            }
            return sum;
        }
        static int maxOfArr(int[,] a, int m, int n)
        {
            int max = int.MinValue;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (max < a[i, j])
                        max = a[i, j];

                }
            }
            return max;
        }
        static int minOfArr(int[,] a, int m, int n)
        {
            int min = int.MaxValue;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (min > a[i, j])
                        min = a[i, j];

                }
            }
            return min;
        }
        static bool checkPrime(int n)
        {
            if (n < 2)
                return false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                        return false;
                }
            }
            return true;
        }
        static List<int> getPrimeArr(int[,] a, int m, int n)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (checkPrime(a[i, j]))
                        res.Add(a[i, j]);
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            int m, n;
            int[,] a = new int[100, 100];
            inputArr(a, out m, out n);
            Console.WriteLine("Mang A la: ");
            displayArr(a, m, n);
            Console.WriteLine("Tong cac phan tu mang A la: {0}", sumOfArr(a, m, n));
            Console.WriteLine("Min A: {0}", minOfArr(a, m, n));
            Console.WriteLine("Max A: {0}", maxOfArr(a, m, n));
            List<int> prime = new List<int>(getPrimeArr(a, m, n));
            while(prime.Count() > 0)
            {
                Console.WriteLine(prime[0]);
                prime.RemoveAt(0);

            }
        }
    }
}
