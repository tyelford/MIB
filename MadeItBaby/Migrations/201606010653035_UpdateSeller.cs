namespace MadeItBaby.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSeller : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sellers", "StoreName", c => c.String(nullable: false));
            AlterColumn("dbo.Sellers", "EmailAddress", c => c.String(nullable: false));
            AlterColumn("dbo.Sellers", "Location", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sellers", "Location", c => c.String());
            AlterColumn("dbo.Sellers", "EmailAddress", c => c.String());
            AlterColumn("dbo.Sellers", "StoreName", c => c.String());
        }
    }
}
