using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PRN231.Models
{
    public class Treatment
    {
        [Key]
        public int treatID { get; set; }
        public string treatName { get; set; }
        public string Description { get; set; }
        public Symptom Symptom { get; set; }
        public ICollection<TreatmentMethod> TreatmentMethods { get; set; }
    }
}
