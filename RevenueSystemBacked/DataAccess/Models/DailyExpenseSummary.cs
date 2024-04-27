using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class DailyExpenseSummary
    {
        public DateTime ExpenseDate { get; set; }  // Property for the expense date
        public decimal TotalExpense { get; set; }  // Property for the total expense
        public string ExpenseStatus { get; set; }  // Property for "Within Limit" or "Out of Limit"
    }
}
