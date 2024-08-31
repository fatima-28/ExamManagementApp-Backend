using AutoMapper;
using ExamManagementApp.Domain.Entities;
using ExamManagementApp.DTO;

namespace ExamManagementApp.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Lesson, LessonDTO>().ReverseMap();
        CreateMap<Exam, ExamDTO>().ReverseMap();         
        CreateMap<Exam, ExamDTOv2>().ReverseMap();         
        CreateMap<Student, StudentDTO>().ReverseMap();

    }
}
