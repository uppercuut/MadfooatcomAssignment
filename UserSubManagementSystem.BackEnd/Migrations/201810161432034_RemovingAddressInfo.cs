namespace UserSubManagementSystem.BackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingAddressInfo : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tbl_Users", "AddressInfo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tbl_Users", "AddressInfo", c => c.String(maxLength: 2000));
        }
    }
}
