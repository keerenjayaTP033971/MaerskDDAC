namespace Maersk_Line.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingID = c.Int(nullable: false, identity: true),
                        ShipID = c.Int(nullable: false),
                        ContainerID = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Date = c.String(nullable: false),
                        Time = c.String(nullable: false),
                        Departure = c.String(nullable: false),
                        Destination = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.BookingID);
            
            CreateTable(
                "dbo.Containers",
                c => new
                    {
                        ContainerID = c.Int(nullable: false, identity: true),
                        ContainerName = c.String(nullable: false),
                        ContainerDescription = c.String(nullable: false),
                        ContainerAmount = c.Int(nullable: false),
                        ContainerWeight = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ContainerID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(nullable: false),
                        EmployeePass = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Ships",
                c => new
                    {
                        ShipCode = c.Int(nullable: false, identity: true),
                        ShipName = c.String(nullable: false),
                        ShipDescription = c.String(nullable: false),
                        NumberOfContainersCarried = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ShipCode);
            
            CreateTable(
                "dbo.ShipYards",
                c => new
                    {
                        ShipyardID = c.Int(nullable: false, identity: true),
                        ShipYardName = c.String(nullable: false),
                        CurrentNumberOfShipsDocked = c.Int(nullable: false),
                        ShipYardDockNumber = c.Int(nullable: false),
                        TotalNumberOfContainers = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ShipyardID);
            
            CreateTable(
                "dbo.Warehouses",
                c => new
                    {
                        WarehouseID = c.Int(nullable: false, identity: true),
                        WarehouseName = c.String(nullable: false),
                        Supervisor = c.String(nullable: false),
                        NumberOfContainersStored = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WarehouseID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Warehouses");
            DropTable("dbo.ShipYards");
            DropTable("dbo.Ships");
            DropTable("dbo.Employees");
            DropTable("dbo.Containers");
            DropTable("dbo.Bookings");
        }
    }
}
