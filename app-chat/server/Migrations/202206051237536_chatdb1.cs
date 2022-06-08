namespace server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chatdb1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "DayOfBirth", c => c.DateTime());
            AddColumn("dbo.User", "Note", c => c.String(storeType: "ntext"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "Note");
            DropColumn("dbo.User", "DayOfBirth");
        }
    }
}
