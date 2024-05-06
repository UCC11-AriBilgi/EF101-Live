﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P02_CodeFirst.Data;

#nullable disable

namespace P02_CodeFirst.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    partial class StudentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("P02_CodeFirst.Entities.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"));

                    b.Property<string>("PAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PEMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PFName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PGender")
                        .HasColumnType("int");

                    b.Property<string>("PLName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PPostCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("P02_CodeFirst.Entities.SClass", b =>
                {
                    b.Property<int>("SClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SClassId"));

                    b.Property<string>("SClassDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SClassName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SClassId");

                    b.ToTable("SClasses");
                });

            modelBuilder.Entity("P02_CodeFirst.Entities.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int>("SClassId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SDoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("SFName")
                        .IsRequired()
                        .HasColumnType("NVarchar(20)");

                    b.Property<string>("SLName")
                        .IsRequired()
                        .HasColumnType("NVarchar(30)");

                    b.HasKey("StudentId");

                    b.HasIndex("SClassId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("P02_CodeFirst.Entities.Student", b =>
                {
                    b.HasOne("P02_CodeFirst.Entities.SClass", "SClass")
                        .WithMany("Students")
                        .HasForeignKey("SClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SClass");
                });

            modelBuilder.Entity("P02_CodeFirst.Entities.SClass", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
