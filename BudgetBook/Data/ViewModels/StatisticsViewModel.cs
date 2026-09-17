namespace BudgetBook.Data.ViewModels
{
    public class StatisticsViewModel
    {
        public decimal TotalIncome { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal Balance { get; set; }
        public List<CategoryExpenseViewModel> ExpensesByCategory { get; set; } = new();
        public List<MonthlyStatisticsViewModel> ByMonth { get; set; } = new();
    }
}
