/*using AutoMapper;
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
    public class SymptomController : ControllerBase
    {
        private readonly ISymptomRepository _symptomRepository;
        private readonly IMapper _mapper;

        public SymptomController(ISymptomRepository symptomRepository, IMapper mapper)
        {
            _symptomRepository = symptomRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetSymptoms()
        {
            var symptoms = _mapper.Map<List<SymptonDto>>(_symptomRepository.GetSymptoms());
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(symptoms);
        }

        [HttpGet("{symptomID}")]
        public IActionResult GetSymptom(int symptomID)
        {
            if (!_symptomRepository.SymptomExist(symptomID)) return NotFound("Symptom is not exists!!");
            var symptom = _mapper.Map<SymptonDto>(_symptomRepository.GetSymptom(symptomID));
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(symptom);
        }

        [HttpPut("{symptomID}")]
        public IActionResult UpdateSymptom(int symptomID, [FromBody] SymptonDto updatedSymptom)
        {
            if (updatedSymptom == null) return BadRequest(ModelState);
            if (symptomID != updatedSymptom.symptomID) return BadRequest(ModelState);
            if (!_symptomRepository.SymptomExist(symptomID)) return NotFound();
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var symptomMap = _mapper.Map<Symptom>(updatedSymptom);

            if (!_symptomRepository.UpdateSymptom(symptomMap))
            {
                ModelState.AddModelError("", "Something was wrong when saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Succes");
        }

        [HttpDelete("{symptomID}")]
        public IActionResult DeleteSymptom(int symptomID)
        {
            if (!_symptomRepository.SymptomExist(symptomID)) return NotFound();
            var symToDelete = _symptomRepository.GetSymptom(symptomID);

            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (!_symptomRepository.DeleteSymptom(symToDelete))
            {
                ModelState.AddModelError("", "Something was wrong when delete");
                return StatusCode(500, ModelState);
            }
            return Ok("Delete Symptom Success");
        }
        [HttpPost]
        public IActionResult CreateSymptom([FromQuery] Guid userID,[FromBody] SymptonDto symptomCreate)
        {
            if (symptomCreate == null) return BadRequest(ModelState);

            var symptom = _symptomRepository.GetSymptoms()
                .Where(c => c.symName.Trim().ToUpper() == symptomCreate.symName.TrimEnd().ToUpper())
                .FirstOrDefault();

            if (symptom != null)
            {
                ModelState.AddModelError("", "Symptom already exists");
                return StatusCode(422, ModelState);
            }

            if (!ModelState.IsValid) return BadRequest(ModelState);

            var symptomMap = _mapper.Map<Symptom>(symptomCreate);

            if (!_symptomRepository.CreateSymptom(userID, symptomMap))
            {
                ModelState.AddModelError("", "Something was wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Create Symptom Success");
        }
    }
}
*/