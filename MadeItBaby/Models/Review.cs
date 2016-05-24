using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MadeItBaby.Models {
    public class Review {
        public int ReviewID { get; set; }
        public string ReviewerEmail { get; set; }
        public string Contents { get; set; }
        public virtual Seller Seller { get; set; }
        public int Rating { get; set; }
    }
}