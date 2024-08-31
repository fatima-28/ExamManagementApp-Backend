using ExamManagementApp.DTO.Base;

namespace ExamManagementApp.DTO
{
    public class StudentDTO: BaseCatalogDTO
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Number { get; set; }

        public int Class { get; set; }
    }
}
