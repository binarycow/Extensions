namespace System.Collections.Generic
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> items) where T : class
        {
            foreach (var item in items)
            {
                if (!(item is null))
                    yield return item;
            }
        }
        public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> items) where T : struct
        {
            foreach (var item in items)
            {
                if (!(item is null))
                    yield return item.Value;
            }
        }
    }
}
