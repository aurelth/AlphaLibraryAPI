namespace AlphaLibraryAPI.Domain.Entities
{
    public class Book
    {
        public Guid BookId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public DateTime PublicationDate { get; set; }
        public bool IsAvailable { get; set; } = true;
        public Guid? BorrowedByStudentId { get; set; }
        public Student? BorrowedBy { get; set; }
        public DateTime? AvailableFrom { get; set; }
    }
}
