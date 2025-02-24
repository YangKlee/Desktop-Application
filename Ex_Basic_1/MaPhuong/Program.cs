using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaPhuong
{

    internal class Program
    {
        static void inilazie(int[,] a, int n)
        {

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    a[i,j] = 0;
                }
            }
        }
        static void display(int[,] a, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write($"{a[i,j]} ");
                }
                Console.WriteLine();
            }
        }
        static void MaPhuongLe(int[,] a, int n)
        {
            int count = 1;
            int i = 1;
            int j = (n / 2) + 1;
            while (count <= (n*n))
            {
                Console.WriteLine($"i= {i}, j={j}, count = {count}");
                // kiểm tra vượt quá hàng
                if (i < 1 && j <= n && j >=1)
                {
                    // xuống hàng đối diện, dịch sang cột 1 đơn vị
                    i = n;
                    Console.WriteLine("Back TH1 !");
                    continue;
                }
                // kiểm tra vượt quá cột
                else if (j > n && i <= n && i >=1)
                {
                    // sang cột đối diện, lùi lên 1 hàng
                    j = 1;
                    Console.WriteLine("Back TH2 !");
                    continue;
                }
                // đéo còn đường đi (vượt cả cột lẫn hàng)
                else if ((i < n && j > n))
                {
                    // đi xuống 1 hàng, giữ nguyên cột
                    i++; j--;
                    i++;
                    Console.WriteLine("Back TH3 !");
                    continue;
                }
                // đéo còn đường đi (ô bị chiếm)
                else if ((a[i , j] != 0) )
                {
                    // đi xuống 1 hàng, giữ nguyên cột
                    i++; j--;
                    i++;
                    Console.WriteLine("Back TH4 !");
                    continue;
                }
                else
                {
                    a[i,j] = count;
                    count++;
                }
                i--; j++; // di chuyển chéo qua phải
            }
        }
        static bool checkMaPhuong(int[,] a, int n)
        {
            
            for (int i = 1; i <= n; i++)
            {
                int sum1 = 0, sum2 = 0, sum3 = 0;
                for (int j = 1; j <= n; j++)
                {
                    sum1 += a[i, j];
                    sum2 += a[j, i];
                    sum3 += a[j, j];
                }
                if (sum1 != sum2 && sum1!= sum3 && sum3 != sum2)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n  = 0;
            n = Int16.Parse(Console.ReadLine());
            int[,] a = new int[1001, 1001];
            inilazie(a, n);
            MaPhuongLe(a, n);
            display(a, n);
            if (checkMaPhuong(a, n))
            {
                Console.WriteLine("True answer");
            }
            else
            {
                Console.WriteLine("False answer");
            }


        }
    }
}
