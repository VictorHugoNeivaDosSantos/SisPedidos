using Microsoft.EntityFrameworkCore;
using SisPedidos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisPedidos.Context
{
    public class ContextDB : DbContext
    {
        DbSet<User> User { get; set; }
        DbSet<Address> Address { get; set; }
        DbSet<Client> Client { get; set; }
        DbSet<Item> Item { get; set; }
        DbSet<Order> Order { get; set; }
        DbSet<OrderItem> OrderItem { get; set; }
        DbSet<People> People { get; set; }

        public ContextDB(DbContextOptions options) : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<User>()
                .Property(p => p.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Address>()
               .HasKey(p => p.Id);
            modelBuilder.Entity<Address>()
                .Property(p => p.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<People>()
               .HasKey(p => p.Id);
            modelBuilder.Entity<People>()
                .Property(p => p.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Order>()
               .HasKey(p => p.Id);
            modelBuilder.Entity<Order>()
                .Property(p => p.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<OrderItem>()
               .HasKey(p => p.Id);
            modelBuilder.Entity<OrderItem>()
                .Property(p => p.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Client>()
               .HasKey(p => p.Id);
            modelBuilder.Entity<Client>()
                .Property(p => p.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Item>()
              .HasKey(p => p.Id);
            modelBuilder.Entity<Item>()
                .Property(p => p.Id).ValueGeneratedOnAdd();


            base.OnModelCreating(modelBuilder);
        }
    }
}
