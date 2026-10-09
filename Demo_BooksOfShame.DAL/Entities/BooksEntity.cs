namespace Demo_BooksOfShame.DAL.Entities
{
    public class BooksEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string? Desc { get; set; }
        public BooksStatusEntity Status { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
