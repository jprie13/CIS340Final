using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StoreApp.Models.DataLayer
{
    public partial class InvoiceItem
    {
        [Key]
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal ProductPrice { get; set; }

        [ForeignKey(nameof(InvoiceId))]
        [InverseProperty("InvoiceItem")]
        public virtual Invoice Invoice { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty("InvoiceItem")]
        public virtual Product Product { get; set; }
    }
}
