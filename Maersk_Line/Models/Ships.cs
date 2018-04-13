using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Maersk_Line.Models
{
    public class Ships
    {
        [Key]
        public int ShipCode { get; set; }
        [Required]
        public string ShipName { get; set; }
        [Required]
        public string ShipDescription { get; set; }
        [Required]
        public int NumberOfContainersCarried { get; set; }
    }
}