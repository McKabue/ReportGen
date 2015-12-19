using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReportGen.Tools
{
    public static class Extentions
    {
        public static void ForEach<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (var item in items)
            {
                action(item);
            }
        }


        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable == null || !enumerable.Any();
        }

    }
}
