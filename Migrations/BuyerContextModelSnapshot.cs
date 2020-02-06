﻿// <auto-generated />
using System;
using EmartMVCCaseStudy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmartMVCCaseStudy.Migrations
{
    [DbContext(typeof(BuyerContext))]
    partial class BuyerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmartMVCCaseStudy.Models.Buyer", b =>
                {
                    b.Property<int>("Bid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BDOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("BEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BMobileNo")
                        .HasColumnType("int");

                    b.Property<string>("BPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BUname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Bid");

                    b.ToTable("Buyers");
                });
#pragma warning restore 612, 618
        }
    }
}
