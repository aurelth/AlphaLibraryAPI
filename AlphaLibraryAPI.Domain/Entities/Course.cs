using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaLibraryAPI.Domain.Entities
{
    public class Course
    {
        public Guid CourseId { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Student> Students { get; set; } = new();
    }
}
