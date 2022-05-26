using API.DTOs;
using AutoMapper;
using CoreLayer.IntService;
using CoreLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkController : ControllerBase
    {
        private IWorkService _workService;
        private IMapper _mapper;

        public WorkController(IWorkService workService, IMapper mapper)
        {
            _workService = workService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var wrk = await _workService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<WorkDto>>(wrk));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var wrk = await _workService.GetByIdAsync(id);
            return Ok(_mapper.Map<WorkDto>(wrk));
        }

        [HttpPost]
        public async Task<IActionResult> Save(WorkDto wrkDto)
        {
            var newWrk = await _workService.AddAsync(_mapper.Map<Work>(wrkDto));
            return Created(string.Empty, _mapper.Map<WorkDto>(newWrk));
        }

        [HttpPut]
        public IActionResult Update(WorkDto wrkDto)
        {
            var wrk = _workService.Update(_mapper.Map<Work>(wrkDto));
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            var wrk = _workService.GetByIdAsync(id).Result;
            _workService.Remove(wrk);
            return NoContent();
        }

        [HttpGet("{id:int}/user")]
        public async Task<IActionResult> GetWitUserByIdAsync(int id)
        {
            IEnumerable<Work> wrk = await _workService.GetWitUserByIdAsync(id);
            return Ok(_mapper.Map<IEnumerable<WorkGetWithUserById>>(wrk));
        }
        
        [HttpGet("{id:int}/category")]
        public async Task<IActionResult> GetWitCategoryByIdAsync(int id)
        {
            IEnumerable<Work> wrk = await _workService.GetWitCategoryByIdAsync(id);
            return Ok(_mapper.Map<IEnumerable<WorkGetWithCategoryById>>(wrk));
        }

        [HttpGet("{id:int}/commnet")]
        public async Task<IActionResult> GetWitCommentByIdAsync(int id)
        {
            IEnumerable<Work> wrk = await _workService.GetWitCommentByIdAsync(id);
            return Ok(_mapper.Map<IEnumerable<WorkGetWithCommentById>>(wrk));
        }


        //[HttpGet("{/allcategory")]
        //public async Task<IActionResult> GetAllWithCategoryAsync()
        //{
        //    IEnumerable<Work> wrk = await _workService.GetAllWithCategoryAsync();
        //    return Ok(_mapper.Map<IEnumerable<WorkGetAllWithCategory>>(wrk));
        //}
        


    }
}
