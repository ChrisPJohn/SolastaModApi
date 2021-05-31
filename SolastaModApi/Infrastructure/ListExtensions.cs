using System.Collections.Generic;

namespace SolastaModApi.Infrastructure
{
    public static class ListExtensions
    {
        public static void AddRangeEx<T>(this List<T> list, params T[] range)
        {
            list.AddRange(range);
        }
    }
}
