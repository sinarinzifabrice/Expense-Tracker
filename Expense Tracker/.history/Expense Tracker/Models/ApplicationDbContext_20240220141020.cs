using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> categories { get; set; }

        
    }
}