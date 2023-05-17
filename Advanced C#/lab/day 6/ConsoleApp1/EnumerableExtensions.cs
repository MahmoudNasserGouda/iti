using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate bool Filter<T>(T obj);
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> collection, Filter<T> filter)
        {
            foreach (var item in collection)
            {
                if (filter(item))
                {
                    yield return item;
                }
            }
        }
    }
}
