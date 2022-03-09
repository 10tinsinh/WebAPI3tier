using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAPI.Repository.Entities
{
    [Table("DetailAccount")]
    [Index(nameof(AccountTypeId), Name = "IX_DetailAccount_AccountType_id")]
    [Index(nameof(AccountId), Name = "IX_DetailAccount_Account_id")]
    public partial class DetailAccount
    {
        [Key]
        [Column("DetailAccount_id")]
        public int DetailAccountId { get; set; }
        [Column("Account_id")]
        public int? AccountId { get; set; }
        [Column("AccountType_id")]
        public int? AccountTypeId { get; set; }

        [ForeignKey(nameof(AccountId))]
        [InverseProperty("DetailAccounts")]
        public virtual Account Account { get; set; }
        [ForeignKey(nameof(AccountTypeId))]
        [InverseProperty("DetailAccounts")]
        public virtual AccountType AccountType { get; set; }
    }
}
