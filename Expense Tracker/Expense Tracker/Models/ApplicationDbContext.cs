using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Expense_Tracker.Models;

namespace Expense_Tracker.Models
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> categories { get; set; }

        public ApplicationDbContext(DbContextOptions options): base(options)
        {  
        }
    }
}