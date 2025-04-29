using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBManager
{
    internal interface DAO<T>
    {
        T get(string query);
        T get(int id);
        DataTable getAll();
        DataTable getElemetsWithQuery(string query);
        bool add(T item);
        bool delete(int id);
        bool delete(T item);
        bool modify(int id, T change);
        bool modify(T oldItem, T newItem);
    }
}
