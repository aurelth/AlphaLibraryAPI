using AlphaLibraryAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AlphaLibraryAPI.Infrastructure.Data
{
    public class LibraryAPIDbContext : DbContext
    {
        public LibraryAPIDbContext(DbContextOptions<LibraryAPIDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Course> Courses { get; set; } = null!;
        public DbSet<BookLoan> BookLoans { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasIndex(s => s.CPF)
                .IsUnique();
        }
    }
}
