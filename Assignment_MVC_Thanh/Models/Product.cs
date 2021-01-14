using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment_MVC_Thanh.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        public string Thumbnail { get; set; }
        
        [Column(TypeName = "text")]
        public string Description { get; set; }
        
        [Column(TypeName = "text")]
        public string Detail { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ApdatedAt { get; set; }
        public ProductStatus Status { get; set; }
    }
    public enum ProductStatus
    {
        ACTIVE,DEACTIVE
    }

}