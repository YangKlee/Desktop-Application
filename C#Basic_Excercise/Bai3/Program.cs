using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static long funcSqr(int n)
        {
            return n * n;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập độ dài cạnh hình vuông: "); 
            try
            {
                Console.WriteLine($"Diện tích hình vuông là: {funcSqr(Int16.Parse(Console.ReadLine()))}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đầu vào sai định dạng!");
            }
        }
    }
}
