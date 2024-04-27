using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class CurrentDayExpense
    {
        public DateTime ExpenseDate { get; set; } 
        public decimal TotalExpense { get; set; } 
    }
}
