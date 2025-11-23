namespace ArtsAndCrafts
{
    public static class PaginationHelper
    {
        // https://stackoverflow.com/questions/6185159/linq-and-pagination
        public static IEnumerable<T> Page<T>(this IEnumerable<T> list, int page, int pageSize)
        {
            return list.Skip((page -  1) * pageSize).Take(pageSize);
        }
    }
}
