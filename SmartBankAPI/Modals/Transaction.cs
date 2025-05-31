using System;
using System.ComponentModel.DataAnnotations;

namespace SmartBankAPI.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        public int SenderId { get; set; }

        [Required]
        public int ReceiverId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        public string? Description { get; set; }

        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}
