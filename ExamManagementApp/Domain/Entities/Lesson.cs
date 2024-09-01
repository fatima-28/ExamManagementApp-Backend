using ExamManagementApp.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExamManagementApp.Domain.Entities;

public class Lesson:BaseEntity
{

    [MaxLength(3, ErrorMessage = "Uzunluq limiti aşılmışdır")]
    [StringLength(3)]
    [Required(ErrorMessage = "Bu field boş ola bilməz!")]
    public string Code { get; set; }

    [MaxLength(30, ErrorMessage = "Uzunluq limiti aşılmışdır")]
    [StringLength(30)]
    [Required(ErrorMessage = "Bu field boş ola bilməz!")]
    public string Name { get; set; }

    [Column(TypeName = "decimal(2, 0)")]       
    [Required(ErrorMessage = "Bu field boş ola bilməz!")]
    public decimal Class { get; set; }

    [Required(ErrorMessage = "Bu field boş ola bilməz!")]
    [StringLength(20)]
    [MaxLength(20, ErrorMessage = "Uzunluq limiti aşılmışdır")]
    public string TeacherName { get; set; }

    [Required(ErrorMessage = "Bu field boş ola bilməz!")]
    [StringLength(20)]
    [MaxLength(20, ErrorMessage = "Uzunluq limiti aşılmışdır")]
    public string TeacherSurname { get; set; }

    public ICollection<Exam> Exams { get; set; }
}
