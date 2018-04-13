using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Maersk_Line.Models
{
    public class Booking
    { 
   [Key]
    public int BookingID { get; set; }
    [Required]
    public int ShipID { get; set; }
    [Required]
    public int ContainerID { get; set; }
    [Required]
    public double Price { get; set; }
    [Required]
    public string Date { get; set; }
    [Required]
    public string Time { get; set; }
    [Required]
    public string Departure { get; set; }
    [Required]
    public string Destination { get; set; }
}
}