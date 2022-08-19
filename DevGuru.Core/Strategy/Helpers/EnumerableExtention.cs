using System.Collections.Generic;
using System.Linq;

namespace DevGuru.Core.Strategy.Helpers
{
    internal static class EnumerableExtention
    {
        public static IEnumerable<T> Swap<T>(this IEnumerable<T> original, int indexFirst, int indexSecond)
        {
            var list = original.ToList();
            T temp = list[indexFirst];
            list[indexFirst] = list[indexSecond];
            list[indexSecond] = temp;
            return list;
        }
    }
}
