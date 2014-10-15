using System;
using System.Collections;
using System.Collections.Generic;

namespace ExtensionMethods
{
    /// <summary>
    /// Dokumentation der offiziellen LINQ Extension Methods:
    /// http://msdn.microsoft.com/en-us/library/system.linq.enumerable_methods.aspx
    /// 
    /// Nutzen Sie diese Dokumentation um Ihre Extension Methods zu implementieren.
    /// Sie finden dort auch die Beschreibung, was die Methode effektiv für einen Effekt hat.
    /// </summary>
    public static class Extensions
    {
        public static void HSRForEach<TSource>(this IEnumerable<TSource> source, Action<TSource> action)
        {
            foreach (TSource item in source)
                action(item);
        }


        public static IEnumerable<T> HSRWhere<T>(this IEnumerable<T> collection, Func<T, bool> statement)
        {
            foreach (T elem in collection)
            {
                if (statement(elem)) {
                    yield return elem;
                }
               
            }
        }

        /* to do
         * 
         *  HSRWhere
         *  
          
         *  HSROfType
         *  HSRToList

         *  HSRAggregate
         *  HSRSum
         *  
         */

    }
}


