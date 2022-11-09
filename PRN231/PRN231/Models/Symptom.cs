using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRN231.Models
{
    public class Symptom
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [StringLength(191)]
        public string Description { get; set; }
        public bool Status { get; set; } = true;
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }

        public ICollection<DiseasesHasSymptoms> DiseasesHasSymptoms { get; set; }
    }
}
