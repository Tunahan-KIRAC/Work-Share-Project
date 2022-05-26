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
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        private IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var usr = await _userService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<UserDto>>(usr));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var usr = await _userService.GetByIdAsync(id);
            return Ok(_mapper.Map<UserDto>(usr));
        }

        [HttpPost]
        public async Task<IActionResult> Save(UserDto usrDto)
        {
            var newusr = await _userService.AddAsync(_mapper.Map<User>(usrDto));
            return Created(string.Empty, _mapper.Map<UserDto>(newusr));
        }

        [HttpPut]
        public IActionResult Update(UserDto usrDto)
        {
            var usr = _userService.Update(_mapper.Map<User>(usrDto));
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            var usr = _userService.GetByIdAsync(id).Result;
            _userService.Remove(usr);
            return NoContent();
        }


        [HttpGet("{id:int}/work")]
        public async Task<IActionResult> GetWitWorkByIdAsync(int id)
        {
            var usr = await _userService.GetWitWorkByIdAsync(id);
            return Ok(_mapper.Map<UserGetWithWorkById>(usr));
        }

        [HttpGet("{id:int}/comments")]
        public async Task<IActionResult> GetWitCommentByIdAsync(int id)
        {
            var usr = await _userService.GetWitCommentByIdAsync(id);
            return Ok(_mapper.Map<UserGetWithCommentById>(usr));
        }        
    }
}
