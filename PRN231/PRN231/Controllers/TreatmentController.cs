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
    public class TreatmentController : ControllerBase
    {
        private readonly ITreatmentRepository _treatmentRepository;
        private readonly ISymptomRepository _symptomRepository;
        private readonly IMapper _mapper;

        public TreatmentController(ITreatmentRepository treatmentRepository,ISymptomRepository symptomRepository, IMapper mapper)
        {
            _treatmentRepository = treatmentRepository;
            _symptomRepository = symptomRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetTreatments()
        {
            var treatments = _mapper.Map<List<TreatmentDto>>(_treatmentRepository.GetTreatments());
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(treatments);
        }

        [HttpGet("{treatID}")]
        public IActionResult GetTreatment(int treatID)
        {
            if (!_treatmentRepository.TreatmentExist(treatID)) return NotFound("Treatment is not exists!!");
            var treatment = _mapper.Map<TreatmentDto>(_treatmentRepository.GetTreatment(treatID));
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(treatment);
        }

        [HttpPut("{treatID}")]
        public IActionResult UpdateTreatment(int treatID, [FromBody] TreatmentDto updatedTreatment)
        {
            if (updatedTreatment == null) return BadRequest(ModelState);
            if (treatID != updatedTreatment.treatID) return BadRequest(ModelState);
            if (!_treatmentRepository.TreatmentExist(treatID)) return NotFound();
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var treatmentMap = _mapper.Map<Treatment>(updatedTreatment);

            if (!_treatmentRepository.UpdateTreatment(treatmentMap))
            {
                ModelState.AddModelError("", "Something was wrong when saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Success");
        }

        [HttpDelete("{treatID}")]
        public IActionResult DeleteTreatment(int treatID)
        {
            if (!_treatmentRepository.TreatmentExist(treatID)) return NotFound();
            var treatToDelete = _treatmentRepository.GetTreatment(treatID);

            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (!_treatmentRepository.DeleteTreatment(treatToDelete))
            {
                ModelState.AddModelError("", "Something was wrong when delete");
                return StatusCode(500, ModelState);
            }
            return Ok("Delete Treatment Success");
        }

        [HttpPost]
        public IActionResult CreateTreatment([FromQuery] int symptomID, [FromBody] TreatmentDto treatmentCreate)
        {
            if (treatmentCreate == null) return BadRequest(ModelState);

            *//*var treatment = _treatmentRepository.GetTreatments()
                .Where(c => c.treatName.Trim().ToUpper() == treatmentCreate.treatName.TrimEnd().ToUpper())
                .FirstOrDefault();

            if (treatment != null)
            {
                ModelState.AddModelError("", "Treatment already exists");
                return StatusCode(422, ModelState);
            }*//*

            if (!ModelState.IsValid) return BadRequest(ModelState);

            var treatmentMap = _mapper.Map<Treatment>(treatmentCreate);
            treatmentMap.Symptom = _symptomRepository.GetSymptom(symptomID);
            if (!_treatmentRepository.CreateTreatment(treatmentMap))
            {
                ModelState.AddModelError("", "Something was wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Create Treatment Success");
        }
    }
}
*/