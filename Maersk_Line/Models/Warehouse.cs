using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Maersk_Line.Models
{
    public class Warehouse
    {
        [Key]
        public int WarehouseID { get; set; }
        [Required]
        public string WarehouseName { get; set; }
        [Required]
        public string Supervisor { get; set; }
        [Required]
        public int NumberOfContainersStored { get; set; }
    }
}