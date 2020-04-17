using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFModels.Models
{
    public class Introduction
    {
        [Key]
        public long CustomerId { get; set; }
        public string AddressLine1 { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student{ get; set; }
    }
}
