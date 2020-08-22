using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.BD.Conections
{    
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("name=ApplicationDbContext") { }
        public ApplicationDbContext(string connectionString) : base(connectionString) { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Model.PaymentMethod> PaymentMethod { get; set; }
        public virtual DbSet<Model.Account> Accounts { get; set; }
        public virtual DbSet<Model.Category> Categories { get; set; }
        public virtual DbSet<Model.CreditCard> CreditCards { get; set; }
        public virtual DbSet<Model.EntryExpenses> Expenses { get; set; }
        public virtual DbSet<Model.SubCategories> SubCategories { get; set; }
        

    }
}
