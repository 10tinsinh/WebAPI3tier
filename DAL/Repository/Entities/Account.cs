using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAPI.Repository.Entities
{
    [Table("Account")]
    public partial class Account
    {
        public Account()
        {
            DetailAccounts = new HashSet<DetailAccount>();
            RefreshTokens = new HashSet<RefreshToken>();
        }

        [Key]
        [Column("Account_id")]
        public int AccountId { get; set; }
        [Required]
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [InverseProperty(nameof(DetailAccount.Account))]
        public virtual ICollection<DetailAccount> DetailAccounts { get; set; }
        [InverseProperty(nameof(RefreshToken.Account))]
        public virtual ICollection<RefreshToken> RefreshTokens { get; set; }
    }
}
