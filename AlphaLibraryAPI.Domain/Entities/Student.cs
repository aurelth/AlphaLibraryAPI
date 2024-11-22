namespace AlphaLibraryAPI.Domain.Entities
{
    public class Student
    {
        public Guid StudentId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public List<BookLoan> Loans { get; set; } = new();
        public List<Course> Courses { get; set; } = new();
    }
}
