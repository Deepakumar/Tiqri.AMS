namespace Tiqri.AMS.DataAccessObject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccidentFieldsUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accident", "History", c => c.String(maxLength: 1000, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accident", "History");
        }
    }
}
