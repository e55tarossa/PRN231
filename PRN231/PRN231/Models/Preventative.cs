using System.ComponentModel.DataAnnotations;

namespace PRN231.Models
{
    public class Preventative
    {
        [Key]
        public int preventID { get; set; }
        public string Description { get; set; }
        public Symptom Symptom { get; set; }
    }
}
