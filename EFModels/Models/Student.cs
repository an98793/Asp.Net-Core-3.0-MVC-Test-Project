using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace EFModels.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public bool Enabled { get; set; }
        [JsonIgnore]
        public virtual ICollection<Introduction> Introductions { get; set; }

    }
}
