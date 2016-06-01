namespace MadeItBaby.Migrations
{
    using MadeItBaby.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MadeItBaby.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MadeItBaby.Models.ApplicationDbContext";
        }

        protected override void Seed(MadeItBaby.Models.ApplicationDbContext context)
        {
            context.Sellers.AddOrUpdate(x => x.SellerID,
                new Seller() {
                    SellerID = 1,
                    StoreName = "Road Runner Fast and Go",
                    Location = "Acme Desert",
                    EmailAddress = "road@runner.com",
                    Slogan = "We get it fast for you!",
                    ProfilePicture = "~/images/profilePics/1.png",
                    FeaturePic1 = "~/images/fp1/1.png",
                    FeaturePic1Description = "Bomb ber ah",
                    FeaturePic2 = "~/images/fp2/1.png",
                    FeaturePic2Description = "Awesome Dynamite",
                    FeaturePic3 = "~/images/fp3/1.png",
                    FeaturePic3Description = "Bombs Away!",
                    HasEtsyStore = true,
                    EtsyLink = "http://etsy.com",
                    HasFBPage = true,
                    FBLink = "http://facebook.com",
                    HasWebPage = true,
                    WebLink = "http://google.com",
                    PhoneNumber = "1800-555-444",
                    Categories = new List<Category>(),
                    Reviews = new List<Review>()
                },
                new Seller() {
                    SellerID = 2,
                    StoreName = "Wiley Coyote Mega Mart",
                    Location = "Acme City",
                    EmailAddress = "coyote@acme.com",
                    Slogan = "Get that road runner!",
                    ProfilePicture = "~/images/profilePics/2.png",
                    FeaturePic1 = "~/images/fp1/2.png",
                    FeaturePic1Description = "Bomb ber ah",
                    FeaturePic2 = "~/images/fp2/2.png",
                    FeaturePic2Description = "Awesome Dynamite",
                    FeaturePic3 = "~/images/fp3/2.png",
                    FeaturePic3Description = "Bombs Away!",
                    HasEtsyStore = true,
                    EtsyLink = "http://etsy.com",
                    HasFBPage = true,
                    FBLink = "http://facebook.com",
                    HasWebPage = true,
                    WebLink = "http://google.com",
                    PhoneNumber = "1800-555-444",
                    Categories = new List<Category>(),
                    Reviews = new List<Review>()
                },
                new Seller() {
                    SellerID = 3,
                    StoreName = "Porky's Pigger",
                    Location = "Acme Farm",
                    EmailAddress = "pig@acme.com",
                    Slogan = "We get it fast for you!",
                    ProfilePicture = "~/images/profilePics/3.png",
                    FeaturePic1 = "~/images/fp1/3.png",
                    FeaturePic1Description = "Bomb ber ah",
                    FeaturePic2 = "~/images/fp2/3.png",
                    FeaturePic2Description = "Awesome Dynamite",
                    FeaturePic3 = "~/images/fp3/3.png",
                    FeaturePic3Description = "Bombs Away!",
                    HasEtsyStore = true,
                    EtsyLink = "http://etsy.com",
                    HasFBPage = true,
                    FBLink = "http://facebook.com",
                    HasWebPage = true,
                    WebLink = "http://google.com",
                    PhoneNumber = "1800-555-444",
                    Categories = new List<Category>(),
                    Reviews = new List<Review>()
                }

                );
        }
    }
}
