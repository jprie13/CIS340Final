using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StoreApp.Models.DataLayer
{
    public partial class Customer
    {
        public Customer()
        {
            Invoice = new HashSet<Invoice>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        [Required]
        [StringLength(25)]
        public string Phone { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Column("UserTypeID")]
        public int UserTypeId { get; set; }

        [ForeignKey(nameof(UserTypeId))]
        [InverseProperty(nameof(UserTypes.Customer))]
        public virtual UserTypes UserType { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<Invoice> Invoice { get; set; }
    }
}
