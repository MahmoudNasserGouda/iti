using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjects
{
    internal static class Extentions
    {
            public static IEnumerable<T> Filter<T>(this IEnumerable<T> lst, Predicate<T> del)
            {
                //List<T> NewList = new List<T>();
                foreach (var item in lst)
                {
                    if (del(item))
                    {
                        //NewList.Add(item);
                        yield return item;  //Deffered
                    }

                }
                //return NewList;


            }
        
    }
}
