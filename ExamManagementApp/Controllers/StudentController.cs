using AutoMapper;
using ExamManagementApp.Domain.Entities;
using ExamManagementApp.DTO;
using ExamManagementApp.Repositories.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace ExamManagementApp.Controllers;

[Route("api/[controller]")]
[ApiController]

public class StudentController : ControllerBase
{
    private readonly IStudentRepository _studentRepository;
    private readonly IMapper _mapper;

    public StudentController(IStudentRepository studentRepository, IMapper mapper)
    {
        _studentRepository = studentRepository;
        _mapper = mapper;
    }

    [HttpPost]

    public async Task<IActionResult> Create(StudentDTO dtoObj)
    {
        var obj = _mapper.Map<Student>(dtoObj);

        await _studentRepository.CreateAsync(obj);

        return Created();
    }

    [HttpPut]

    public async Task<IActionResult> Update(StudentDTO dtoObj)
    {
        var obj = _mapper.Map<Student>(dtoObj);

        var result = await _studentRepository.UpdateAsync(obj);

        return Ok(result);
    }

    [HttpDelete("{id}")]

    public async Task<IActionResult> Delete(int id)
    {
        var result = await _studentRepository.DeleteAsync(id);

        return Ok(result);
    }

    [HttpGet("{id}")]

    public async Task<IActionResult> Get(int id)
    {
        var obj = await _studentRepository.GetByIdAsync(id);

        var result = _mapper.Map<StudentDTO>(obj);

        return Ok(result);
    }

    [HttpGet]

    public async Task<IActionResult> GetAll()
    {
        var objects = await _studentRepository.GetAllAsync();

        var result = _mapper.Map<IEnumerable<StudentDTO>>(objects);

        return Ok(result);
    }


}
