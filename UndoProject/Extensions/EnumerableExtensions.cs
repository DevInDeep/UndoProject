using System;
using System.Collections.Generic;

namespace UndoProject.Extensions
{
    internal static class EnumerableExtensions
    {
        internal static void Do<T>(this IEnumerable<T> enumeration, Action<T> onItem)
        {
            foreach (var item in enumeration)
                onItem(item);
        }
    }
}
