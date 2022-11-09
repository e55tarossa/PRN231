/*using PRN231.Data;
using PRN231.Interfaces;
using PRN231.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PRN231.Repository
{
    public class TreatmentRepository : ITreatmentRepository
    {
        private readonly DataContext _context;

        public TreatmentRepository(DataContext context)
        {
            _context = context;
        }
        public bool TreatmentExist(int id)
        {
            return _context.Treatments.Any(f => f.treatID == id);
        }

        public Treatment GetTreatment(int id)
        {
            return _context.Treatments.Where(s => s.treatID == id).FirstOrDefault();
        }

        public ICollection<Treatment> GetTreatments()
        {
            return _context.Treatments.ToList();
        }

        public bool UpdateTreatment(Treatment treatment)
        {
            _context.Update(treatment);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool CreateTreatment( Treatment treatment)
        {
            _context.Add(treatment);
            return Save();
        }

        public bool DeleteTreatment(Treatment treatment)
        {
            _context.Remove(treatment);
            return Save();
        }
    }
}
*/