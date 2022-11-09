using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PRN231.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid userID { get; set; }
        public string Email { get; set; }
        public string userName { get; set; }
        public string Address { get; set; }
        public bool isAdmin { get; set; } = false;
        public ICollection<UserSymptom> UserSymptoms { get; set; }
    }
}
