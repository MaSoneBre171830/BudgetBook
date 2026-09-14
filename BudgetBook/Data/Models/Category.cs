using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BudgetBook.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        
        public TransactionType Type { get; set; }
        public bool IsActive { get; set; } = true;

        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

    }
}
