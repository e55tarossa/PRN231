/*using PRN231.Data;
using PRN231.Interfaces;
using PRN231.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PRN231.Repository
{
    public class SymptomRepository : ISymptomRepository
    {
        private readonly DataContext _context;

        public SymptomRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreateSymptom(Guid userID, Symptom symptom)
        {
            var symptomUserEntity = _context.Users.Where(o => o.userID == userID).FirstOrDefault();

            //Add zo model join table
            var userSymptom = new UserSymptom()
            {
                User = symptomUserEntity,
                Symptom = symptom,
            };
            _context.Add(userSymptom);
            _context.Add(symptom);
            return Save();
        }

        public bool DeleteSymptom(Symptom symptom)
        {
            _context.Remove(symptom);
            return Save();
        }

        public Symptom GetSymptom(int id)
        {
            return _context.Symptoms.Where(s => s.symptomID == id).FirstOrDefault();
        }

        public ICollection<Symptom> GetSymptoms()
        {
            return _context.Symptoms.ToList();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool SymptomExist(int id)
        {
            return _context.Symptoms.Any(s => s.symptomID == id);
        }

        public bool UpdateSymptom(Symptom symptom)
        {
            _context.Update(symptom);
            return Save();
        }
    }
}
*/