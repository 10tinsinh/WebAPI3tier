using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAPI.Repository.Entities
{
    [Table("AccountType")]
    public partial class AccountType
    {
        public AccountType()
        {
            DetailAccounts = new HashSet<DetailAccount>();
        }

        [Key]
        [Column("AccountType_id")]
        public int AccountTypeId { get; set; }
        [Required]
        [Column("Name_type")]
        [StringLength(50)]
        public string NameType { get; set; }

        [InverseProperty(nameof(DetailAccount.AccountType))]
        public virtual ICollection<DetailAccount> DetailAccounts { get; set; }
    }
}
