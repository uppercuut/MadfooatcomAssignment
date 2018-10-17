namespace UserSubManagementSystem.BackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationAddingAddressInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_Users", "AddressInfo", c => c.String(maxLength: 2000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tbl_Users", "AddressInfo");
        }
    }
}
