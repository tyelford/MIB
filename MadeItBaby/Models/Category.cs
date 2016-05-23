using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
 * Categories Model
 * Used to define the categories that will be avilable 
 * from the search screen
 */

namespace MadeItBaby.Models {
    public class Category {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public int ParentCategory { get; set; }
        public string Value { get; set; }
    }
}