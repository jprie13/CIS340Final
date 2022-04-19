using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StoreApp.Models.DataLayer
{
    public partial class Invoice
    {
        public Invoice()
        {
            InvoiceItem = new HashSet<InvoiceItem>();
        }

        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PurchaseDate { get; set; }

        [ForeignKey(nameof(CustomerId))]
        [InverseProperty("Invoice")]
        public virtual Customer Customer { get; set; }
        [InverseProperty("Invoice")]
        public virtual ICollection<InvoiceItem> InvoiceItem { get; set; }
    }
}
