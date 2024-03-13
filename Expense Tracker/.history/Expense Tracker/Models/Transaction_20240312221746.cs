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
        [Range(1,int.MaxValue,ErrorMessage ="")]
        public int  CategoryId { get; set; }
        public Category? Category { get; set; }
        public int Amount { get; set; }
        
        [Column(TypeName = "nvarchar(75)")]
        public string? Note { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        
        [NotMapped]

        public string? CategoryTitleWithIcon { 
            get{
                return Category == null? "": Category.TitleWithIcon;
            
            } 
        }

        [NotMapped]

        public string? FormattedAmount { 
            get{
                return ((Category == null || Category.Type == "Expense")? "- ": "+ ") + Amount.ToString("C0");
            
            } 
        }

    }
}