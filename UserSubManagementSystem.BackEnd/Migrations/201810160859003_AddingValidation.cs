namespace UserSubManagementSystem.BackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Users", "DateOfBirth", c => c.DateTime());
            AlterColumn("dbo.Users", "Mobile", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Users", "Country", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Users", "City", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Users", "Street", c => c.String(nullable: false, maxLength: 300));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Street", c => c.String());
            AlterColumn("dbo.Users", "City", c => c.String());
            AlterColumn("dbo.Users", "Country", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Users", "Mobile", c => c.String());
            AlterColumn("dbo.Users", "DateOfBirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "Name", c => c.String());
        }
    }
}
