using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StoreApp.Models.DataLayer
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            Product = new HashSet<Product>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty("Category")]
        public virtual ICollection<Product> Product { get; set; }
    }
}
