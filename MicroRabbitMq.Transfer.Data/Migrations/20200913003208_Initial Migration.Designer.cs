﻿// <auto-generated />
using MicroRabbitMq.Transfer.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MicroRabbitMq.Transfer.Data.Migrations
{
    [DbContext(typeof(TransferDbContext))]
    [Migration("20200913003208_Initial Migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-preview.8.20407.4");

            modelBuilder.Entity("MicroRabbitMq.Transfer.Domain.Models.TransferLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("FromAccount")
                        .HasColumnType("int");

                    b.Property<int>("ToAccount")
                        .HasColumnType("int");

                    b.Property<decimal>("TransferAmount")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("Id");

                    b.ToTable("TransferLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
