using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetBook.Data.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        [Range(typeof(decimal), "0,01", "999999999999", ErrorMessage = "Amount must be greater than zero.")]
        public decimal Amount { get; set; }
        public DateTime BookingDate { get; set; }
        public TransactionType Type { get; set; }
        public string Description { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "Please select a category.")]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public string UserId { get; set; } = string.Empty;
        public ApplicationUser User { get; set; } = null!;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
