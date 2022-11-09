/*using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PRN231.Dto;
using PRN231.Interfaces;
using PRN231.Models;
using PRN231.Repository;
using System.Collections.Generic;
using System.Linq;

namespace PRN231.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreventativeController : ControllerBase
    {
        private readonly IPreventativeRepository _preventativeRepository;
        private readonly IMapper _mapper;

        public PreventativeController(IPreventativeRepository preventativeRepository, IMapper mapper)
        {
            _preventativeRepository = preventativeRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetPreventatives()
        {
            var preventatives = _mapper.Map<List<PreventativeDto>>(_preventativeRepository.GetPreventatives());
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(preventatives);
        }

        [HttpGet("{preventID}")]
        public IActionResult GetPreventative(int preventID)
        {
            if (!_preventativeRepository.PreventativeExist(preventID)) return NotFound("Preventative is not exists!!");
            var preventative = _mapper.Map<PreventativeDto>(_preventativeRepository.GetPreventative(preventID));
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(preventative);
        }

        [HttpPut("{preventID}")]
        public IActionResult UpdatePreventative(int preventID, [FromBody] PreventativeDto updatedPreventative)
        {
            if (updatedPreventative == null) return BadRequest(ModelState);
            if (preventID != updatedPreventative.preventID) return BadRequest(ModelState);
            if (!_preventativeRepository.PreventativeExist(preventID)) return NotFound();
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var preventativeMap = _mapper.Map<Preventative>(updatedPreventative);

            if (!_preventativeRepository.UpdatePreventative(preventativeMap))
            {
                ModelState.AddModelError("", "Something was wrong when saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Success");
        }

        [HttpDelete("{preventID}")]
        public IActionResult DeletePreventative(int preventID)
        {
            if (!_preventativeRepository.PreventativeExist(preventID)) return NotFound();
            var prevToDelete = _preventativeRepository.GetPreventative(preventID);

            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (!_preventativeRepository.DeletePreventative(prevToDelete))
            {
                ModelState.AddModelError("", "Something was wrong when delete");
                return StatusCode(500, ModelState);
            }
            return Ok("Delete Preventative Success");
        }

        [HttpPost]
        public IActionResult CreatePreventative([FromBody] PreventativeDto preventativeCreate)
        {
            if (preventativeCreate == null) return BadRequest(ModelState);

            if (!ModelState.IsValid) return BadRequest(ModelState);

            var preventativeMap = _mapper.Map<Preventative>(preventativeCreate);

            if (!_preventativeRepository.CreatePreventative(preventativeMap))
            {
                ModelState.AddModelError("", "Something was wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Post Preventative Success");
        }
    }
}
*/