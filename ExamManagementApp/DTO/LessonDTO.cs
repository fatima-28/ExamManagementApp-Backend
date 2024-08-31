using ExamManagementApp.DTO.Base;

namespace ExamManagementApp.DTO
{
    public class LessonDTO: BaseCatalogDTO
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public decimal Class { get; set; }

        public string TeacherName { get; set; }

        public string TeacherSurname { get; set; }
    }
}
