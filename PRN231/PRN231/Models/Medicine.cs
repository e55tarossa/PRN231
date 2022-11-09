using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PRN231.Models
{
    public class Medicine
    {
        [Key]
        public int medicineID { get; set; }
        public string medicineName { get; set; }
        public string Description { get; set; }
        public string Attachment { get; set; }
        public ICollection<TreatmentMethod> TreatmentMethods { get; set; }
    }
}
