using ExamManagementApp.Domain.Entities;
using ExamManagementApp.DTO.Base;

namespace ExamManagementApp.DTO
{
    public class ExamDTO:BaseCatalogDTO
    {
        public int LessonId { get; set; }

        public int StudentId { get; set; }

        public Lesson Lesson { get; set; }

        public Student Student { get; set; }

        public DateTime Date { get; set; }

        public decimal Grade { get; set; }

       
    }
}
