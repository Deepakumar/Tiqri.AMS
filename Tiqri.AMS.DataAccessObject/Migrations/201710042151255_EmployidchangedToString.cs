namespace Tiqri.AMS.DataAccessObject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployidchangedToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accident", "ReporterID", c => c.String(nullable: false, maxLength: 128, unicode: false));
            AlterColumn("dbo.Victim", "EmployeeID", c => c.String(maxLength: 128, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Victim", "EmployeeID", c => c.Int());
            AlterColumn("dbo.Accident", "ReporterID", c => c.Int(nullable: false));
        }
    }
}
