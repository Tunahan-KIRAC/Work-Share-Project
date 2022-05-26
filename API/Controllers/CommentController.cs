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
    public class CommentController : ControllerBase
    {
        private ICommentService _comService;
        private IMapper _mapper;

        public CommentController(ICommentService comService, IMapper mapper)
        {
            _comService = comService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var com = await _comService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<CommentDto>>(com));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var com = await _comService.GetByIdAsync(id);
            return Ok(_mapper.Map<CommentDto>(com));
        }

        [HttpPost]
        public async Task<IActionResult> Save(CommentDto comDto)
        {
            var newCom = await _comService.AddAsync(_mapper.Map<Comment>(comDto));
            return Created(string.Empty, _mapper.Map<CommentDto>(newCom));
        }
        [HttpPut]
        public IActionResult Update(CommentDto comDto)
        {
            var com = _comService.Update(_mapper.Map<Comment>(comDto));
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            var com = _comService.GetByIdAsync(id).Result;
            _comService.Remove(com);
            return NoContent();
        }

        [HttpGet("{id:int}/work")]
        public async Task<IActionResult> GetWithWorkByIdAsync(int id)
        {
            IEnumerable<Comment> com = await _comService.GetWithWorkByIdAsync(id);
            return Ok(_mapper.Map<IEnumerable<CommentGetWithWorkById>>(com));
        }

        [HttpGet("{id:int}/user")]
        public async Task<IActionResult> GetWitUserByIdAsync(int id)
        {
            IEnumerable<Comment> com = await _comService.GetWitUserByIdAsync(id);
            return Ok(_mapper.Map<IEnumerable<CommentGetWithUserById>>(com));
        }

    }
}
