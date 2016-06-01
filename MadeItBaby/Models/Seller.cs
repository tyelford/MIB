using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

/*
 * Used to describe a seller
 */

namespace MadeItBaby.Models {
    public class Seller {
        public int SellerID { get; set; }

        //Initial Required Fields
        [Required]
        [Display(Name="Store Name")]
        public string StoreName { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        [Display(Name="Email Address")]
        public string EmailAddress { get; set; }

        //Extra Fields
        public string Slogan { get; set; }
        public string ProfilePicture { get; set; }
        public string FeaturePic1 { get; set; }
        public string FeaturePic1Description { get; set; }
        public string FeaturePic2 { get; set; }
        public string FeaturePic2Description { get; set; }
        public string FeaturePic3 { get; set; }
        public string FeaturePic3Description { get; set; }
        public bool HasEtsyStore { get; set; }
        public string EtsyLink { get; set; }
        public bool HasFBPage { get; set; }
        public string FBLink { get; set; }
        public bool HasWebPage { get; set; }
        public string WebLink { get; set; }
        public string PhoneNumber { get; set; }
        public virtual List<Category> Categories { get; set; }
        public virtual List<Review> Reviews{ get; set; }

    }
}