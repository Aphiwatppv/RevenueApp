using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class ExpenseIncomeRecordAdd
    {
        public string Account { get; set; } = "Aphiwat"; // Default value
        public int DetailId { get; set; } // Foreign key reference to DetailIncomeExpenseTB
        public string IsIncomeOrExpense { get; set; } // Either 'Income' or 'Expense'
        public decimal Value { get; set; } // Income or expense amount
        public DateTime? Date { get; set; } // Nullable, defaulting to the current date
    }

}
