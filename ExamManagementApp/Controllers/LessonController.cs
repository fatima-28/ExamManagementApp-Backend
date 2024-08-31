using AutoMapper;
using ExamManagementApp.Domain.Entities;
using ExamManagementApp.DTO;
using ExamManagementApp.Repositories.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace ExamManagementApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class LessonController : ControllerBase
    {

        private readonly ILessonRepository _LessonRepository;
        private readonly IMapper _mapper;

        public LessonController(ILessonRepository LessonRepository, IMapper mapper)
        {
            _LessonRepository = LessonRepository;
            _mapper = mapper;
        }

        [HttpPost]

        public async Task<IActionResult> Create(LessonDTO dtoObj)
        {
            var obj = _mapper.Map<Lesson>(dtoObj);

            await _LessonRepository.CreateAsync(obj);

            return Created();
        }

        [HttpPut]

        public async Task<IActionResult> Update(LessonDTO dtoObj)
        {
            var obj = _mapper.Map<Lesson>(dtoObj);

            var result = await _LessonRepository.UpdateAsync(obj);

            return Ok(result);
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _LessonRepository.DeleteAsync(id);

            return Ok(result);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> Get(int id)
        {
            var obj = await _LessonRepository.GetByIdAsync(id);

            var result = _mapper.Map<LessonDTO>(obj);

            return Ok(result);
        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var objects = await _LessonRepository.GetAllAsync();

            var result = _mapper.Map<IEnumerable<LessonDTO>>(objects);

            return Ok(result);
        }

    }
}
