using Microsoft.EntityFrameworkCore;

namespace account_api
{
    public class AccountDb : DbContext
    {
        public AccountDb(DbContextOptions options)
            : base(options)
        {}
        public DbSet<Account> Accounts { get; set; }  
   
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Account>().HasData(
                new Account 
                {
                    Id = 1,
                    First = "bob",
                    Last = "smith",
                    Email = "bob.smith@gmail.com"
                },
                new Account 
                {
                    Id = 2,
                    First = "jim",
                    Last = "roberts",
                    Email = "jim.roberts@gmail.com"
                },
                new Account 
                {
                    Id = 3,
                    First = "alison",
                    Last = "jacobs",
                    Email = "alison.jacobs@aol.com"
                }
            );
        }
    }
}