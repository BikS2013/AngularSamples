using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryList
{
    public static class Extensions
    {
        public static void AddIfNotExistOrException<T>(this List<T> list, T item, Func<bool> chkCondition)
        {
            if (chkCondition())
            {
                throw new Exception("item already exists");
            }
            list.Add(item);
        }

        public static void AddIfNotExistOrException<T>(this List<T> list, T item, Func<List<T>, bool> chkCondition)
        {
            list.AddIfNotExistOrException(item, () => chkCondition(list));
        }
        public static void AddIfNotExistOrException<T>(this List<T> list, T item, Func<List<T>, T, bool> chkCondition)
        {
            list.AddIfNotExistOrException(item, () => chkCondition(list, item));
        }
        public static void AddIfNotExistOrException<T>(this List<T> list, T item, Func<T, bool> chkCondition)
        {
            list.AddIfNotExistOrException(item, () => chkCondition(item));
        }
    }
}
