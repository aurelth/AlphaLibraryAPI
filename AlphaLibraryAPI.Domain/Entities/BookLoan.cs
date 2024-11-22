namespace AlphaLibraryAPI.Domain.Entities
{
    public class BookLoan
    {
        public Guid BookLoanId { get; set; }
        public Guid BookId { get; set; }
        public Book Book { get; set; } = null!;
        public Guid StudentId { get; set; }
        public Student Student { get; set; } = null!;
        public DateTime BorrowedDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}
