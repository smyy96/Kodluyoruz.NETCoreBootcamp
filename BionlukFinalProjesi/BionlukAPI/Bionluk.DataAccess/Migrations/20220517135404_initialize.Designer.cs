﻿// <auto-generated />
using Bionluk.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bionluk.DataAccess.Migrations
{
    [DbContext(typeof(BionlukDbContext))]
    [Migration("20220517135404_initialize")]
    partial class initialize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Bionluk.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Profession = "Yazılım & Teknoloji"
                        },
                        new
                        {
                            CategoryId = 2,
                            Profession = "Psikoloji"
                        },
                        new
                        {
                            CategoryId = 3,
                            Profession = "Network"
                        },
                        new
                        {
                            CategoryId = 4,
                            Profession = "SEO"
                        },
                        new
                        {
                            CategoryId = 5,
                            Profession = "UI/UX"
                        });
                });

            modelBuilder.Entity("Bionluk.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            About = "C# ile otomasyon ödevlerinizi yapabilirim.",
                            CategoryId = 1,
                            Email = "sumeyyecoskun.sc@gmail.com",
                            Name = "Sümeyye",
                            PhoneNum = "555454545",
                            Price = 100,
                            Surname = "Coşkun",
                            Title = "Bilgisayar Mühendisi"
                        },
                        new
                        {
                            Id = 2,
                            About = "Beni kollarınızın arasına alıp severseniz gırlama sesim ile psikolojinizi düzeltebilirim. (Sarılmayı fazla abartmayın tırnaklarım.)",
                            CategoryId = 2,
                            Email = "",
                            Name = "Bulut",
                            PhoneNum = "",
                            Price = 10000,
                            Surname = "Işık",
                            Title = "Ben bir kediyim."
                        },
                        new
                        {
                            Id = 3,
                            About = "Ben, bitcoin ödeme ağ geçitli network marketing yazılımı yaparım",
                            CategoryId = 3,
                            Email = "selim@gmail.com",
                            Name = "Selim",
                            PhoneNum = "000011111",
                            Price = 350,
                            Surname = "Aklı",
                            Title = "Web Yazılım"
                        });
                });

            modelBuilder.Entity("Bionluk.Entities.User", b =>
                {
                    b.HasOne("Bionluk.Entities.Category", "Category")
                        .WithMany("Users")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Bionluk.Entities.Category", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
