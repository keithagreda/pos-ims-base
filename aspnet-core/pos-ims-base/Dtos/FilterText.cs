namespace pos_ims_base.Dtos
{
    public class FilterText : PaginationParams
    {
        public string? Text { get; set; }
    }

    public class PaginationParams : PaginationSorting
    {
        private int _maxItemsPerPage = 50;
        private int itemsPerPage = 10;
        public int Page { get; set; } = 1;
        public int ItemsPerPage
        {
            get => itemsPerPage;
            set => itemsPerPage = value > _maxItemsPerPage ? _maxItemsPerPage : value;
        }
    }

    public class PaginationSorting
    {
        public string? Sorting { get; set; }
    }
}
