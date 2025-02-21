using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongSo1
{
    internal class Program
    {
        static string sumString(string a, string b)
        {
            string result = "";
            // cân bằng 2 số trước khi cộng
            while (a.Length < b.Length)
            {
                a = "0" + a;
            }
            while (b.Length < a.Length)
            {
                b = "0" + b;
            }
          
            int m =  0; // nhớ
            for (int i = a.Length - 1; i >= 0; i--)
            {
                int kq = (a[i] - '0') + (b[i] - '0') ;
                //Console.WriteLine(kq);
                kq += m;
                m = 0;
                if (kq >= 10)
                {
                    m = (kq / 10);
                    kq = (kq % 10);
                }
                //Console.WriteLine(kq);

                result = (char)(kq + '0') + result;
                
            }
            if (m > 0)
                result = (char)(m + '0') + result;
            return result;
        }
        static void Main(string[] args)
        {
            // Viết chương trình cộng hai số nguyên dương bất kỳ (không quá 256 chữ số).
            // Giải pháp: Cộng chuỗi 2 số
            string a, b;
            a = Console.ReadLine();
            b = Console.ReadLine();
            Console.WriteLine($"{a}+{b} = {sumString(a, b)}");
        }
    }
}
