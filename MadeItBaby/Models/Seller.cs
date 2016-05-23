using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
 * Used to describe a seller
 */

namespace MadeItBaby.Models {
    public class Seller {
        public int SellerID { get; set; }
        public string StoreName { get; set; }
        public string Slogan { get; set; }
        public string ProfilePicture { get; set; }
        public string FeaturePic1 { get; set; }
        public string FreaturePic1Description { get; set; }
        public string FeaturePic2 { get; set; }
        public string FeaturePic2Description { get; set; }
        public string FeaturePic3 { get; set; }
        public string FeaturedPic3Description { get; set; }
        public bool HasEtsyStore { get; set; }
        public string EtsyLink { get; set; }
        public bool HasFBPage { get; set; }
        public string FBLink { get; set; }
        public bool HasWebPage { get; set; }
        public string WebLink { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Location { get; set; }
        public virtual List<Category> Categories { get; set; }
    }
}