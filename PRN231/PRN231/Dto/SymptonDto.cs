using System.ComponentModel.DataAnnotations;
using System;

namespace PRN231.Dto
{
    public class SymptonDto
    {
        public int symptomID { get; set; }
        public string symName { get; set; }
        public string Description { get; set; }
        public DateTime createdAt { get; set; }
        public string Attachment { get; set; }

        public bool isActive { get; set; } = true;
        public bool isDelete { get; set; } = false;
    }
}
