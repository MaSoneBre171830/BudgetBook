namespace BudgetBook.Data.ViewModels
{
    public class MonthlyStatisticsViewModel
    {
        public DateTime Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Balance  { get; set; }
    }
}
