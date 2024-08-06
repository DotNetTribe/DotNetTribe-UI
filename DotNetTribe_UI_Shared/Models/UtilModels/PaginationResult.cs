namespace DotNetTribe_UI_Shared.Models.UtilModels
{
    public class PaginationResult<T> where T : class
    {
        public int currentPage { get; set; }
        public int totalPages { get; set; }
        public int totalRecords { get; set; }
        public int pageSize { get; set; }
        public IEnumerable<T> records { get; set; } = null!;
    }
}