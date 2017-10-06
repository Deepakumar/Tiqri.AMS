namespace Tiqri.AMS.DataAccessObject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployidchangedToString1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accident", "AccidentDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accident", "AccidentDate");
        }
    }
}
