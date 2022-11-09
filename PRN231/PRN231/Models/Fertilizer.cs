using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PRN231.Models
{
    public class Fertilizer
    {
        [Key]
        public int fertID { get; set; }
        public string fertName { get; set; }
        public string Description { get; set; }
        public string Attachment { get; set; }
        public ICollection<TreatmentMethod> TreatmentMethods { get; set; }
    }
}
