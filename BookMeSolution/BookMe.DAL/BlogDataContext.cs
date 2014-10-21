﻿using System.Data.Entity;
using BookMe.DAL;

namespace BookMe.DAL
{
    public class BlogDataContext:DbContext
    {
        public BlogDataContext():base("BlogConnectionString")
        {
           // Database.SetInitializer<BlogDataContext>(new BlogDbInitializer());
         //Database.SetInitializer(new MigrateDatabaseToLatestVersion<BlogDataContext, Configuration>("BlogConnectionString"));
          Database.SetInitializer<BlogDataContext>(null);
          
        }
      
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; } 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //User
            modelBuilder.Entity<User>().Property(e => e.FirstName).HasMaxLength(250).IsRequired();
            modelBuilder.Entity<User>().Property(e => e.LastName).HasMaxLength(250).IsRequired();
            modelBuilder.Entity<User>().Property(e => e.Avatar).HasMaxLength(1000);
            modelBuilder.Entity<User>().Property(e => e.UserName).IsRequired().HasMaxLength(250);
          modelBuilder.Entity<User>().Property(e => e.Password).HasMaxLength(250).IsRequired();

          //Role
            modelBuilder.Entity<Role>().Property(e => e.Name).HasMaxLength(250).IsRequired();

            //category
            
            base.OnModelCreating(modelBuilder);

         

        }
    }
}
