using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expense_Tracker.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int  CategoryId { get; set; }
        public string? Note { get; set; }
        public DateTime Date { get; set; } = Da
    }
}