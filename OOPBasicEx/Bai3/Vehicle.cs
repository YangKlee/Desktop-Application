using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Vehicle
    {
        public string strType { set; get; }
        public string strColor { set; get; }
        public double dblSpeed { set; get; }
        public string strBrand { set; get; }

        public virtual void Run()
        {
            Console.WriteLine(strType + " : I am running");
        }
        public void Display()
        {
            
        }

    }
}
