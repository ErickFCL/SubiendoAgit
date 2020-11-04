using Microsoft.EntityFrameworkCore;
using Practicando.Models.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practicando.Models
{
    public class FinancistoContext: DbContext
    {

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }


        public FinancistoContext(DbContextOptions<FinancistoContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AccountMap());
            modelBuilder.ApplyConfiguration(new TypeMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new TransactionMap());
        }
    }
}
