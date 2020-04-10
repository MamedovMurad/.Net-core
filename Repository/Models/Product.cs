﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
  public  class Product: BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(50)]
        public string SKU { get; set; }
        [Required]
        [MaxLength(500)]
        public string  Description { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        public string Text { get; set; }

        [Required]
        
        public decimal Price { get; set; }
        public int? LabelId { get; set; }
        public Category Category { get; set; }
        public Label Label { get; set; }
        
        public byte StarCount { get; set; }
        [Required]
        public bool IsTopSelling { get; set; }
        [Required]
        public bool IsFeatured { get; set; }
        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<ProductPhoto> Photos { get; set; }
        public ICollection<ProductReview> Reviews { get; set; }
        public ICollection<ProductOption> Options { get; set; }
        public ICollection<ProductDiscount> Discounts { get; set; }
        public ICollection<Basket> Baskets { get; set; }
    }
}
