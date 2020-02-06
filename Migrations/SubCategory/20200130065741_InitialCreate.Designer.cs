﻿// <auto-generated />
using EmartMVCCaseStudy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmartMVCCaseStudy.Migrations.SubCategory
{
    [DbContext(typeof(SubCategoryContext))]
    [Migration("20200130065741_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmartMVCCaseStudy.Models.SubCategory", b =>
                {
                    b.Property<string>("SubId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubId");

                    b.ToTable("SubCategorys");
                });
#pragma warning restore 612, 618
        }
    }
}