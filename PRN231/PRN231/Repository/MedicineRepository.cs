/*using PRN231.Data;
using PRN231.Interfaces;
using PRN231.Models;
using System.Collections.Generic;
using System.Linq;

namespace PRN231.Repository
{
    public class MedicineRepository : IMedicineRepository
    {
        private readonly DataContext _context;

        public MedicineRepository(DataContext context)
        {
            _context = context;
        }
        public bool MedicineExist(int id)
        {
            return _context.Medicines.Any(f => f.medicineID == id);
        }

        public Medicine GetMedicine(int id)
        {
            return _context.Medicines.Where(s => s.medicineID == id).FirstOrDefault();
        }

        public ICollection<Medicine> GetMedicines()
        {
            return _context.Medicines.ToList();
        }

        public bool UpdateMedicine(Medicine medicine)
        {
            _context.Update(medicine);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool CreateMedicine(Medicine medicine)
        {
            _context.Add(medicine);
            return Save();
        }

        public bool DeleteMedicine(Medicine medicine)
        {
            _context.Remove(medicine);
            return Save();
        }
    }
}
*/