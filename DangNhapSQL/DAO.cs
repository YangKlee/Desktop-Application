using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangNhapSQL
{
    internal interface DAO<T>
    {
        void Add(T obj);
       T Get(string query);

    }
}
