using FainaKvitochka_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System;

namespace FainaKvitochka_DAL
{
    public class EFCoreDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemSale> ItemSales { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<CollectionBase> Collections { get; set; }
        public DbSet<KeyWord> KeyWords { get; set; }
        public DbSet<ItemKeyWord> ItemKeyWords { get; set; }
        public DbSet<ItemColor> ItemColors { get; set; }
        public DbSet<ItemCollectionBase> ItemCollections { get; set; }
        public DbSet<FilePath> FilePaths { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<User> Users { get; set; }

        protected EFCoreDbContext()
        {
        }

        public EFCoreDbContext(DbContextOptions<EFCoreDbContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Item>().Has
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
}
