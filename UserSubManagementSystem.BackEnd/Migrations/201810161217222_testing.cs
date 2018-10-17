namespace UserSubManagementSystem.BackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testing : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Users", newName: "tbl_Users");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.tbl_Users", newName: "Users");
        }
    }
}
