﻿using GuniKitchen.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuniKitchen.Models
{
        public class Product
        {
            [Key]
            [Display(Name = "Product ID")]
            public int ProductId { get; set; }


            [Display(Name = "Product Name")]
            public string ProductName { get; set; }

            public string Description { get; set; }

            public double Price { get; set; }

            public string ImageURL { get; set; }

            public ProductCategory ProductCategory { get; set; }
        }
}
