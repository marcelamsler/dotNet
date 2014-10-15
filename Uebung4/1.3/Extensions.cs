using System;
using System.Collections.Generic;

namespace ExtensionMethods
{
    public static class Extensions
    {
        public static void ForEachElem<T> (this IEnumerable<T> collection, Action<T> f)
        {
            foreach(T elem in collection) {
                f(elem);

            }
        }
    }
}

