using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Expense_Tracker.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Clolumn]
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Type { get; set; }
    }
}