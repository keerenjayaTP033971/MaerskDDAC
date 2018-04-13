using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Maersk_Line.Models
{
    public class Maersk_LineContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Maersk_LineContext() : base("name=Maersk_LineContext")
        {
        }

        public System.Data.Entity.DbSet<Maersk_Line.Models.Booking> Bookings { get; set; }

        public System.Data.Entity.DbSet<Maersk_Line.Models.Container> Containers { get; set; }

        public System.Data.Entity.DbSet<Maersk_Line.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<Maersk_Line.Models.Ships> Ships { get; set; }

        public System.Data.Entity.DbSet<Maersk_Line.Models.ShipYard> ShipYards { get; set; }

        public System.Data.Entity.DbSet<Maersk_Line.Models.Warehouse> Warehouses { get; set; }
    }
}
