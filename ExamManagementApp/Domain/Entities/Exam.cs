using ExamManagementApp.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamManagementApp.Domain.Entities
{
    public class Exam:BaseEntity
    {
        public int LessonId { get; set; }

        [ForeignKey("LessonId")]
        public Lesson Lesson { get; set; }

        public int StudentId { get; set; } 

        [ForeignKey("StudentId")]
        public Student Student { get; set; }

        public DateTime Date { get; set; }

        [Column(TypeName = "decimal(1, 0)")]
        public decimal Grade { get; set; }   
    }
}
