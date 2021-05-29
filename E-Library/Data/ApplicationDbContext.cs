using E_Library.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_Library.Data
{
    public class ApplicationDbContext : DbContext
    {

#if DEBUG
        public ApplicationDbContext()
            : base("Server=(localdb)\\mssqllocaldb;Database=e_library;Trusted_Connection=True;MultipleActiveResultSets=true")
        {
            var ad = this.UsersAccounts.Count();
            if(ad < 1)
            {
                this.UsersAccounts.Add(new UsersAccount { Id = Guid.NewGuid(), Username = "admin", Password = "admin" });
                this.SaveChanges();
            }
        
        }
#else
    public ApplicationDbContext()
       : base("Data Source=SQL5104.site4now.net;Initial Catalog=db_a73b90_evoting;User Id=db_a73b90_evoting_admin;Password=Horlarlekhan1#")
        {
            var ad = this.UsersAccounts.Count();
            if(ad < 1)
            {
                this.UsersAccounts.Add(new UsersAccount { Id = Guid.NewGuid(), Username = "admin", Password = "admin" });
                this.SaveChanges();
            }
        }
#endif


        public DbSet<User> Users { set; get; }
        public DbSet<Bookmark> Bookmarks { set; get; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Course> Courses { set; get; }
        public DbSet<Subscription> Subscriptions { set; get; }
        public DbSet<Book> Books { set; get; }
        public DbSet<UserSubscription> UserSubscriptions { set; get; }
        public DbSet<UsersAccount> UsersAccounts { set; get; }
        public DbSet<PaymentHistory> PaymentHistories { set; get; }


        
    }
}