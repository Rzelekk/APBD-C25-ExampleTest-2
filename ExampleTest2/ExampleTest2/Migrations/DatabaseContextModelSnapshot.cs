﻿// <auto-generated />
using System;
using ExampleTest2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExampleTest2.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExampleTest2.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Jan",
                            LastName = "Kowalski"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Anna",
                            LastName = "Nowak"
                        });
                });

            modelBuilder.Entity("ExampleTest2.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Adam",
                            LastName = "Nowak"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Aleksandra",
                            LastName = "Wiśniewska"
                        });
                });

            modelBuilder.Entity("ExampleTest2.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AcceptedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FulfilledAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AcceptedAt = new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ClientId = 1,
                            Comments = "Lorem ipsum ...",
                            EmployeeId = 2,
                            FulfilledAt = new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            AcceptedAt = new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ClientId = 1,
                            Comments = "Lorem ipsum ...",
                            EmployeeId = 1,
                            FulfilledAt = new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            AcceptedAt = new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ClientId = 2,
                            EmployeeId = 1
                        });
                });

            modelBuilder.Entity("ExampleTest2.Models.OrderPastry", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("PastryId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("OrderId", "PastryId");

                    b.HasIndex("PastryId");

                    b.ToTable("Order_Pastry");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            PastryId = 1,
                            Amount = 3
                        },
                        new
                        {
                            OrderId = 1,
                            PastryId = 3,
                            Amount = 4,
                            Comment = "Lorem ipsum ..."
                        },
                        new
                        {
                            OrderId = 2,
                            PastryId = 2,
                            Amount = 2
                        },
                        new
                        {
                            OrderId = 2,
                            PastryId = 1,
                            Amount = 12
                        });
                });

            modelBuilder.Entity("ExampleTest2.Models.Pastry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Pastries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Drożdzówka",
                            Price = 3.3m,
                            Type = "A"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Babka cytrynowa",
                            Price = 21.23m,
                            Type = "B"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Jagodzianka",
                            Price = 7.2m,
                            Type = "A"
                        });
                });

            modelBuilder.Entity("ExampleTest2.Models.Order", b =>
                {
                    b.HasOne("ExampleTest2.Models.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExampleTest2.Models.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("ExampleTest2.Models.OrderPastry", b =>
                {
                    b.HasOne("ExampleTest2.Models.Order", "Order")
                        .WithMany("OrderPastries")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExampleTest2.Models.Pastry", "Pastry")
                        .WithMany("OrderPastries")
                        .HasForeignKey("PastryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Pastry");
                });

            modelBuilder.Entity("ExampleTest2.Models.Client", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ExampleTest2.Models.Employee", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ExampleTest2.Models.Order", b =>
                {
                    b.Navigation("OrderPastries");
                });

            modelBuilder.Entity("ExampleTest2.Models.Pastry", b =>
                {
                    b.Navigation("OrderPastries");
                });
#pragma warning restore 612, 618
        }
    }
}
