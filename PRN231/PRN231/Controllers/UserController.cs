using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PRN231.Dto;
using PRN231.Interfaces;
using PRN231.Models;
using PRN231.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PRN231.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /*private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _mapper.Map<List<User>>(_userRepository.GetUsers());
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(users);
        }

        [HttpGet("{userID}")]
        public IActionResult GetUser(Guid userID)
        {
            if (!_userRepository.UserExists(userID)) return NotFound("User is not exists");
            var user = _mapper.Map<User>(_userRepository.GetUser(userID));

            if (!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(user);
        }

        [HttpPut("{userID}")]
        public IActionResult UpdateUser(Guid userID, [FromBody] UserDto updatedUser)
        {
            if (updatedUser == null) return BadRequest(ModelState);
            if (userID != updatedUser.userID) return BadRequest(ModelState);
            if (!_userRepository.UserExists(userID)) return NotFound();
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var symptomMap = _mapper.Map<User>(updatedUser);

            if (!_userRepository.UpdateUser(symptomMap))
            {
                ModelState.AddModelError("", "Something was wrong when saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Succes");
        }

        [HttpDelete("{userID}")]
        public IActionResult DeleteUser(Guid userID)
        {
            if (!_userRepository.UserExists(userID)) return NotFound();
            var userToDelete = _userRepository.GetUser(userID);

            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (!_userRepository.DeleteUser(userToDelete))
            {
                ModelState.AddModelError("", "Something was wrong when delete");
                return StatusCode(500, ModelState);
            }
            return Ok("Delete User Success");
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] UserDto userCreate)
        {
            if (userCreate == null) return BadRequest(ModelState);

            var user = _userRepository.GetUsers()
                .Where(c => c.Email.Trim().ToUpper() == userCreate.Email.TrimEnd().ToUpper())
                .FirstOrDefault();

            if (user != null)
            {
                ModelState.AddModelError("", "User already exists");
                return StatusCode(422, ModelState);
            }

            if (!ModelState.IsValid) return BadRequest(ModelState);

            var userMap = _mapper.Map<User>(userCreate);

            if (!_userRepository.CreateUser(userMap))
            {
                ModelState.AddModelError("", "Something was wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Create User Success");
        }*/
    }
}
