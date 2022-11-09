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
    public class FertilizerController : ControllerBase
    {
        private readonly IFertilizerRepository _fertilizerRepository;
        private readonly IMapper _mapper;

        public FertilizerController(IFertilizerRepository fertilizerRepository, IMapper mapper)
        {
            _fertilizerRepository = fertilizerRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetFertilizers()
        {
            var fertilizers = _mapper.Map<List<FertilizerDto>>(_fertilizerRepository.GetFertilizers());
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(fertilizers);
        }

        [HttpGet("{fertID}")]
        public IActionResult GetFertilizer(int fertID)
        {
            if (!_fertilizerRepository.FertilizerExist(fertID)) return NotFound("Fertilizer is not exists!!");
            var fertilizer = _mapper.Map<FertilizerDto>(_fertilizerRepository.GetFertilizer(fertID));
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(fertilizer);
        }

        [HttpPut("{fertID}")]
        public IActionResult UpdateFertilizer(int fertID, [FromBody] FertilizerDto updatedFertilizer)
        {
            if (updatedFertilizer == null) return BadRequest(ModelState);
            if (fertID != updatedFertilizer.fertID) return BadRequest(ModelState);
            if (!_fertilizerRepository.FertilizerExist(fertID)) return NotFound();
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var medicineMap = _mapper.Map<Fertilizer>(updatedFertilizer);

            if (!_fertilizerRepository.UpdateFertilizer(medicineMap))
            {
                ModelState.AddModelError("", "Something was wrong when saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Updated Fertilizer Success");
        }

        [HttpDelete("{fertID}")]
        public IActionResult DeleteFertilizer(int fertID)
        {
            if (!_fertilizerRepository.FertilizerExist(fertID)) return NotFound();
            var fertToDelete = _fertilizerRepository.GetFertilizer(fertID);

            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (!_fertilizerRepository.DeleteFertilizer(fertToDelete))
            {
                ModelState.AddModelError("", "Something was wrong when delete");
                return StatusCode(500, ModelState);
            }
            return Ok("Delete Succes");
        }

        [HttpPost]
        public IActionResult CreateFertilizer([FromBody] FertilizerDto fertilizerCreate)
        {
            if (fertilizerCreate == null) return BadRequest(ModelState);

            var fertilizer = _fertilizerRepository.GetFertilizers()
                .Where(c => c.fertName.Trim().ToUpper() == fertilizerCreate.fertName.TrimEnd().ToUpper())
                .FirstOrDefault();

            if (fertilizer != null)
            {
                ModelState.AddModelError("", "Fertilizer already exists");
                return StatusCode(422, ModelState);
            }

            if (!ModelState.IsValid) return BadRequest(ModelState);

            var fertilizerMap = _mapper.Map<Fertilizer>(fertilizerCreate);

            if (!_fertilizerRepository.CreateFertilizer(fertilizerMap))
            {
                ModelState.AddModelError("", "Something was wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Thanh cong");
        }
    }
}
*/