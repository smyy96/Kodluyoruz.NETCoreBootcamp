using Bionluk.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bionluk.DataAccess.Data
{
    public class BionlukDbContext : DbContext
    {
        

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }


        public BionlukDbContext(DbContextOptions<BionlukDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(x => x.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<User>().HasOne(p => p.Category)
                .WithMany(c => c.Users)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Category>().HasData(
                new Category() { CategoryId = 1, Profession="Yazılım & Teknoloji"},
                new Category() { CategoryId = 2, Profession="Psikoloji"},
                new Category() { CategoryId = 3, Profession="Network"},
                new Category() { CategoryId = 4, Profession="SEO"},
                new Category() { CategoryId = 5, Profession="UI/UX"}
                );

            modelBuilder.Entity<User>().HasData(
                new User() { Id = 1, Name = "Sümeyye", Surname = "Coşkun", Email = "sumeyyecoskun.sc@gmail.com", PhoneNum = "555454545", Price = 100, About = "C# ile otomasyon ödevlerinizi yapabilirim.", Title = "Bilgisayar Mühendisi", CategoryId = 1 },

                new User() { Id = 2, Name = "Bulut", Surname = "Işık", Email = "", PhoneNum = "", Price = 10000, About = "Beni kollarınızın arasına alıp severseniz gırlama sesim ile psikolojinizi düzeltebilirim. (Sarılmayı fazla abartmayın tırnaklarım.)", Title = "Ben bir kediyim.", CategoryId = 2 },

                new User() { Id = 3, Name = "Selim", Surname = "Aklı", Email = "selim@gmail.com", PhoneNum = "000011111", Price = 350, About = "Ben, bitcoin ödeme ağ geçitli network marketing yazılımı yaparım", Title = "Web Yazılım", CategoryId = 3 }

                );
                
                
                
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
