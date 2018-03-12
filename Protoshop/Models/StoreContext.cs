using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Protoshop.Models {
    public class StoreContext {
        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}