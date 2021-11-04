using API_Case.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace API_Case.DB
{
    public class SqliteDbContext: DbContext 
    {

        public DbSet<Addresses> Addresses { get; set; }


        protected override void onConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite("FileName=sqlitedb1", option =>
            {

                option.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);

            });

              base.OnConfiguring(optionsBuilder);
        }


        protected override void onModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Addresses>().ToTable("Addresses");
            modelBuilder.Entity<Addresses>(entity =>
            {

                entity.HasKey(k => k.Id);
                entity.HasIndex(i => i.Street).IsUnique();


            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
