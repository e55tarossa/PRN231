using PRN231.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PRN231.Interfaces
{
    public interface ISymptomRepository
    {
        ICollection<Symptom> GetSymptoms();
        Symptom GetSymptom(int id);
        bool SymptomExist(int id);
        bool UpdateSymptom(Symptom symptom);
        bool CreateSymptom(Guid userID, Symptom symptom);
        bool DeleteSymptom(Symptom symptom);
        bool Save();
    }
}
