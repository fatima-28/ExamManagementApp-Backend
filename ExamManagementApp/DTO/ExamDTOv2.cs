using ExamManagementApp.DTO.Base;

namespace ExamManagementApp.DTO
{
    public class ExamDTOv2:BaseCatalogDTO
    {
        public int LessonId { get; set; }

        public int StudentId { get; set; }

        public DateTime Date { get; set; }

        public decimal Grade { get; set; }
    }
}
