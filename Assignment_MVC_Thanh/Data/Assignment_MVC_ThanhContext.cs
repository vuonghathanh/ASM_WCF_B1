using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assignment_MVC_Thanh.Data
{
    public class Assignment_MVC_ThanhContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Assignment_MVC_ThanhContext() : base("name=Assignment_MVC_ThanhContext")
        {
        }

        public System.Data.Entity.DbSet<Assignment_MVC_Thanh.Models.Product> Products { get; set; }
    }
}
