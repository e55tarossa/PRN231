using System;

namespace PRN231.Models
{
    public class UserSymptom
    {
        public Guid userID { get; set; }
        public int symptomID { get; set; }
        public User User { get; set; }
        public Symptom Symptom { get; set; }
    }
}
