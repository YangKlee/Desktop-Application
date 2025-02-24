using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaPhuongLe
{
    internal class Program
    {
        static void inilazie(int[,] a, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                a[i, i] = 0;
            }
        }
        static void show(int[,]a, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n;
            n = Int16.Parse(Console.ReadLine());
            int[,] a = new int[101, 101];
            inilazie(a, n);
            int count = 1;
            a[1, (n / 2) + 1] = 1;
            int i = 1, j = n/2;

            while (count <= n*n)
            {


            }
            show(a, n);

        }
    }
}
