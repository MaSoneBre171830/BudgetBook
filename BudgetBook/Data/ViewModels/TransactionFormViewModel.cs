using BudgetBook.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace BudgetBook.Data.ViewModels
{
    public class TransactionFormViewModel
    {
        public string Description { get; set; } = string.Empty;

        [Range(0.01, 1000000)]
        public decimal Amount { get; set; }

        [Required]
        public DateTime BookingDate { get; set; } = DateTime.Today;

        [Required]
        public TransactionType Type { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select a category.")]
        public int CategoryId { get; set; }
    }
}
