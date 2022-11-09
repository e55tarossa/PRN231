using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRN231.Models
{
    public class Notification
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Title { get; set; }
        [Required]
        [StringLength(100)]
        public string Body { get; set; }
        public Guid? UserId { get; set; }
        [Required]
        public long PredictionId { get; set; }
        public bool Status { get; set; } = true;
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }

        /*[ForeignKey("UserId")]
        public virtual User User { get; set; }*/
        [ForeignKey("PredictionId")]
        public virtual Prediction Prediction { get; set; }
    }
}
