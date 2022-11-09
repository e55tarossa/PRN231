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
    public class MedicineController : ControllerBase
    {
        private readonly IMedicineRepository _medicineRepository;
        private readonly IMapper _mapper;

        public MedicineController(IMedicineRepository medicineRepository, IMapper mapper)
        {
            _medicineRepository = medicineRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetMedicines()
        {
            var medicines = _mapper.Map<List<MedicineDto>>(_medicineRepository.GetMedicines());
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(medicines);
        }

        [HttpGet("{medicineID}")]
        public IActionResult GetMedicine(int medicineID)
        {
            if (!_medicineRepository.MedicineExist(medicineID)) return NotFound("Medicine is not exists!!");
            var medicine = _mapper.Map<MedicineDto>(_medicineRepository.GetMedicine(medicineID));
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(medicine);
        }

        [HttpPut("{medicineID}")]
        public IActionResult UpdateMedicine(int medicineID, [FromBody] MedicineDto updatedMedicine)
        {
            if (updatedMedicine == null) return BadRequest(ModelState);
            if (medicineID != updatedMedicine.medicineID) return BadRequest(ModelState);
            if (!_medicineRepository.MedicineExist(medicineID)) return NotFound();
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var medicineMap = _mapper.Map<Medicine>(updatedMedicine);

            if (!_medicineRepository.UpdateMedicine(medicineMap))
            {
                ModelState.AddModelError("", "Something was wrong when saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Updated Medicine Success");
        }

        [HttpDelete("{medicineID}")]
        public IActionResult DeleteMedicine(int medicineID)
        {
            if (!_medicineRepository.MedicineExist(medicineID)) return NotFound();
            var fertToDelete = _medicineRepository.GetMedicine(medicineID);

            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (!_medicineRepository.DeleteMedicine(fertToDelete))
            {
                ModelState.AddModelError("", "Something was wrong when delete");
                return StatusCode(500, ModelState);
            }
            return Ok("Delete Medicine Success");
        }

        [HttpPost]
        public IActionResult CreateMedicine([FromBody] MedicineDto medicineCreate)
        {
            if (medicineCreate == null) return BadRequest(ModelState);

            var medicine = _medicineRepository.GetMedicines()
                .Where(c => c.medicineName.Trim().ToUpper() == medicineCreate.medicineName.TrimEnd().ToUpper())
                .FirstOrDefault();

            if (medicine != null)
            {
                ModelState.AddModelError("", "Medicine already exists");
                return StatusCode(422, ModelState);
            }

            if (!ModelState.IsValid) return BadRequest(ModelState);

            var medicineMap = _mapper.Map<Medicine>(medicineCreate);

            if (!_medicineRepository.CreateMedicine(medicineMap))
            {
                ModelState.AddModelError("", "Something was wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Create Medicine Success");
        }
    }
}
*/