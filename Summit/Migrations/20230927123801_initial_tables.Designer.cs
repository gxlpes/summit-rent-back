﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Summit.Data;

#nullable disable

namespace Summit.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230927123801_initial_tables")]
    partial class initial_tables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Summit.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("car_id");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<string>("Plate")
                        .HasColumnType("longtext")
                        .HasColumnName("plate");

                    b.Property<bool>("isRented")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("rented");

                    b.HasKey("Id");

                    b.ToTable("cars");
                });

            modelBuilder.Entity("Summit.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("client_id");

                    b.Property<string>("Cpf")
                        .HasColumnType("longtext")
                        .HasColumnName("cpf");

                    b.Property<string>("Email")
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext")
                        .HasColumnName("password_hash");

                    b.Property<string>("PasswordSalt")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("Summit.Models.Dealership", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("dealership_id");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("City")
                        .HasColumnType("longtext")
                        .HasColumnName("city");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<string>("State")
                        .HasColumnType("longtext")
                        .HasColumnName("estado");

                    b.HasKey("Id");

                    b.ToTable("dealerships");
                });

            modelBuilder.Entity("Summit.Models.Departure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("departures");
                });

            modelBuilder.Entity("Summit.Models.Destination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("destinations");
                });

            modelBuilder.Entity("Summit.Models.Insurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("car_id");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.Property<double>("price")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("insurances");
                });

            modelBuilder.Entity("Summit.Models.Intent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("intent_id");

                    b.Property<string>("CarId")
                        .HasColumnType("longtext")
                        .HasColumnName("car_id");

                    b.Property<string>("ClientId")
                        .HasColumnType("longtext")
                        .HasColumnName("client_id");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date");

                    b.HasKey("Id");

                    b.ToTable("intents");
                });

            modelBuilder.Entity("Summit.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("car_id");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("longtext");

                    b.Property<Guid?>("customerId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("customerId");

                    b.ToTable("payments");
                });

            modelBuilder.Entity("Summit.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("car_id");

                    b.Property<string>("Comment")
                        .HasColumnType("longtext")
                        .HasColumnName("comment");

                    b.Property<double>("Grade")
                        .HasColumnType("double")
                        .HasColumnName("grade");

                    b.Property<int?>("RentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RentId");

                    b.ToTable("ratings");
                });

            modelBuilder.Entity("Summit.Models.Rent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("CarId")
                        .HasColumnType("int");

                    b.Property<Guid?>("ClientId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date");

                    b.Property<int?>("PaymentId")
                        .HasColumnType("int");

                    b.Property<int?>("departureId")
                        .HasColumnType("int");

                    b.Property<int?>("destinationId")
                        .HasColumnType("int");

                    b.Property<int?>("insuranceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("ClientId");

                    b.HasIndex("PaymentId");

                    b.HasIndex("departureId");

                    b.HasIndex("destinationId");

                    b.HasIndex("insuranceId");

                    b.ToTable("rents");
                });

            modelBuilder.Entity("Summit.Models.Payment", b =>
                {
                    b.HasOne("Summit.Models.Customer", "customer")
                        .WithMany()
                        .HasForeignKey("customerId");

                    b.Navigation("customer");
                });

            modelBuilder.Entity("Summit.Models.Rating", b =>
                {
                    b.HasOne("Summit.Models.Rent", "Rent")
                        .WithMany()
                        .HasForeignKey("RentId");

                    b.Navigation("Rent");
                });

            modelBuilder.Entity("Summit.Models.Rent", b =>
                {
                    b.HasOne("Summit.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId");

                    b.HasOne("Summit.Models.Customer", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("Summit.Models.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId");

                    b.HasOne("Summit.Models.Departure", "departure")
                        .WithMany()
                        .HasForeignKey("departureId");

                    b.HasOne("Summit.Models.Destination", "destination")
                        .WithMany()
                        .HasForeignKey("destinationId");

                    b.HasOne("Summit.Models.Insurance", "insurance")
                        .WithMany()
                        .HasForeignKey("insuranceId");

                    b.Navigation("Car");

                    b.Navigation("Client");

                    b.Navigation("Payment");

                    b.Navigation("departure");

                    b.Navigation("destination");

                    b.Navigation("insurance");
                });
#pragma warning restore 612, 618
        }
    }
}