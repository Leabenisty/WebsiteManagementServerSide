﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Solid.Data;

#nullable disable

namespace Solid.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240120182853_one-to-manyfinish")]
    partial class onetomanyfinish
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Web_API.Core.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SalaryId")
                        .HasColumnType("int");

                    b.Property<int>("WorkHoursId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SalaryId");

                    b.HasIndex("WorkHoursId");

                    b.ToTable("DataEmployee");
                });

            modelBuilder.Entity("Web_API.Core.Models.Salary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Basesalary")
                        .HasColumnType("float");

                    b.Property<double>("Bouns")
                        .HasColumnType("float");

                    b.Property<double>("Finalesalary")
                        .HasColumnType("float");

                    b.Property<int>("Idemployee")
                        .HasColumnType("int");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<bool>("Paidup")
                        .HasColumnType("bit");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DataSalary");
                });

            modelBuilder.Entity("Web_API.Core.Models.Workhours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<int>("HoursDay")
                        .HasColumnType("int");

                    b.Property<int>("IdEmployee")
                        .HasColumnType("int");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DataWorkhours");
                });

            modelBuilder.Entity("Web_API.Core.Models.Employee", b =>
                {
                    b.HasOne("Web_API.Core.Models.Salary", "Salary")
                        .WithMany()
                        .HasForeignKey("SalaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Web_API.Core.Models.Workhours", "WorkHours")
                        .WithMany()
                        .HasForeignKey("WorkHoursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Salary");

                    b.Navigation("WorkHours");
                });
#pragma warning restore 612, 618
        }
    }
}
