using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Expense_Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public int  CategoryId { get; set; }
        public Category? Category { get; set; }
        public int Amount { get; set; }
        
        [Column(TypeName = "nvarchar(75)")]
        public string? Note { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string? CategoryTitleWithIcon { 
            get{
                return Category == null? "": Category.
            
        } }
    }
}