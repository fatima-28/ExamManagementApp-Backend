using AutoMapper;
using ExamManagementApp.Domain.Entities;
using ExamManagementApp.DTO;
using ExamManagementApp.Repositories.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace ExamManagementApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ExamController : ControllerBase
    {
        private readonly IExamRepository _examRepository;
        private readonly IMapper _mapper;

        public ExamController(IExamRepository ExamRepository, IMapper mapper)
        {
            _examRepository = ExamRepository;
            _mapper = mapper;
        }

        [HttpPost]

        public async Task<IActionResult> Create(ExamDTOv2 dtoObj)
        {

            var obj = _mapper.Map<Exam>(dtoObj);

            var rs = await _examRepository.CreateAsync(obj);

            return Created();
        }

        [HttpPut]

        public async Task<IActionResult> Update(ExamDTOv2 dtoObj)
        {
            var obj = _mapper.Map<Exam>(dtoObj);

            var result = await _examRepository.UpdateAsync(obj);

            return Ok(result);
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _examRepository.DeleteAsync(id);

            return Ok(result);
        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var objects = await _examRepository.GetAllAsync();

            var result = _mapper.Map<IEnumerable<ExamDTO>>(objects);

            return Ok(result);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> Get(int id)
        {
            var obj = await _examRepository.GetByIdAsync(id);

            var result = _mapper.Map<ExamDTO>(obj);

            return Ok(result);
        }

        
    }
}
