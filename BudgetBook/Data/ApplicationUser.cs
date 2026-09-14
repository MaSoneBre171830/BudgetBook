using BudgetBook.Data.Models;
using Microsoft.AspNetCore.Identity;


namespace BudgetBook.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }

}
