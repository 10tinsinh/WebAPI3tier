using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAPI.Repository.Entities
{
    [Table("RefreshToken")]
    [Index(nameof(AccountId), Name = "IX_RefreshToken_AccountId")]
    public partial class RefreshToken
    {
        [Key]
        public Guid Id { get; set; }
        public int AccountId { get; set; }
        public string Token { get; set; }
        public string JwtId { get; set; }
        public bool IsUsed { get; set; }
        public bool IsRevoked { get; set; }
        public DateTime IssueAt { get; set; }
        public DateTime ExpriredAt { get; set; }

        [ForeignKey(nameof(AccountId))]
        [InverseProperty("RefreshTokens")]
        public virtual Account Account { get; set; }
    }
}
