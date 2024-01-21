using System.Collections.Generic;
using System.Linq;

namespace DevGuru.Patterns.Strategy.Helpers
{
    internal static class EnumerableExtention
    {
        public static IEnumerable<T> Swap<T>(this IEnumerable<T> original, int indexFirst, int indexSecond)
        {
            var list = original.ToList();
            (list[indexSecond], list[indexFirst]) = (list[indexFirst], list[indexSecond]);
            return list;
        }
    }
}
