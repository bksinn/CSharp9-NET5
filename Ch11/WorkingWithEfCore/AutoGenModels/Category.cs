﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Packt.Shared.AutoGen
{
    [Index(nameof(CategoryName), Name = "CategoryName")]
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        [Column("CategoryID")]
        public long CategoryId { get; set; }
        [Column(TypeName = "nvarchar (15)")]
        public string CategoryName { get; set; } = null!;
        [Column(TypeName = "ntext")]
        public string? Description { get; set; }
        [Column(TypeName = "image")]
        public byte[]? Picture { get; set; }

        [InverseProperty(nameof(Product.Category))]
        public virtual ICollection<Product> Products { get; set; }
    }
}
