namespace MadeItBaby.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedmethod : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sellers", "FeaturePic1Description", c => c.String());
            AddColumn("dbo.Sellers", "FeaturePic3Description", c => c.String());
            DropColumn("dbo.Sellers", "FreaturePic1Description");
            DropColumn("dbo.Sellers", "FeaturedPic3Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sellers", "FeaturedPic3Description", c => c.String());
            AddColumn("dbo.Sellers", "FreaturePic1Description", c => c.String());
            DropColumn("dbo.Sellers", "FeaturePic3Description");
            DropColumn("dbo.Sellers", "FeaturePic1Description");
        }
    }
}
