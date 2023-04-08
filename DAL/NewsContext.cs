using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NewsContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<News> News { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasKey(c => c.Id)
                .Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<News>()
                .HasKey(n => n.Id)
                .Property(n => n.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<News>()
                .HasRequired(n => n.Category)
                .WithMany()
                .HasForeignKey(n => n.CategoryId);
        }
    }
}
