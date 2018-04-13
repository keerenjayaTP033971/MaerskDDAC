using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Maersk_Line.Models
{
    public class ShipYard
    {
        [Key]
        public int ShipyardID { get; set; }
        [Required]
        public string ShipYardName { get; set; }
        [Required]
        public int CurrentNumberOfShipsDocked { get; set; }
        [Required]
        public int ShipYardDockNumber { get; set; }
        [Required]
        public int TotalNumberOfContainers { get; set; }
    }
}