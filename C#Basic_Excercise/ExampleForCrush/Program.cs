using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleForCrush
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> deerClub = new List<String>
            {
                "Nokotan",
                "Basameme",
                "Koshitan",
                "Koshi Anko"
            };

            Console.WriteLine($"Hello , we are a big deer club. We have {deerClub.Count()} members. ");
            Console.WriteLine("List of member: {0} and we so happy. Wellcome to deer club", deerClub[0], deerClub[1], deerClub[2], deerClub[3]);
        }
    }
}
