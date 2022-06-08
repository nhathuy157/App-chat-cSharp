namespace server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chatdb : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.User", "DayOfBirth");
            DropColumn("dbo.User", "Note");
        }
        
        public override void Down()
        {
            AddColumn("dbo.User", "Note", c => c.String(storeType: "ntext"));
            AddColumn("dbo.User", "DayOfBirth", c => c.DateTime());
        }
    }
}
