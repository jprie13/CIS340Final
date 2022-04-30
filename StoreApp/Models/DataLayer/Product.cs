using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StoreApp.Models.DataLayer
{
    public partial class Product
    {
        public Product()
        {
            InvoiceItem = new HashSet<InvoiceItem>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Price { get; set; }
        [Column("CategoryID")]
        public int CategoryId { get; set; }
        public int IsActive { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty(nameof(ProductCategory.Product))]
        public virtual ProductCategory Category { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<InvoiceItem> InvoiceItem { get; set; }
    }
}
