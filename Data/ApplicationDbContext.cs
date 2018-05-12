using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using number_cruncher.Models;

namespace number_cruncher.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<ClientCategory> ClientCategory { get; set; }
        public DbSet<Expense> Expense { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategory { get; set; }
        public DbSet<ExpenseRecord> ExpenseRecord { get; set; }
        public DbSet<ExpenseRecordImage> ExpenseRecordImage { get; set; }
        public DbSet<Paycheck> Paycheck { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>()
                .Property(a => a.DateCreated)
                .HasDefaultValueSql("strftime('%Y-%m-%d %H:%M:%S')");
        }
    }
}