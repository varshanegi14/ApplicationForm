﻿// <auto-generated />
using ApplicationForm.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApplicationForm.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240617194029_AddTeamwwess")]
    partial class AddTeamwwess
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApplicationForm.Entity.BooleanTypeClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Awnser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Questionid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Questionid")
                        .IsUnique();

                    b.ToTable("BooleanTypeClass");
                });

            modelBuilder.Entity("ApplicationForm.Entity.DropDownClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Awnser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Questionid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Questionid")
                        .IsUnique();

                    b.ToTable("DropDownClass");
                });

            modelBuilder.Entity("ApplicationForm.Entity.FormNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("forms");
                });

            modelBuilder.Entity("ApplicationForm.Entity.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FormId")
                        .HasColumnType("int");

                    b.Property<int>("FormNumberId")
                        .HasColumnType("int");

                    b.Property<string>("QuestionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FormNumberId");

                    b.ToTable("questions");
                });

            modelBuilder.Entity("ApplicationForm.Entity.TextTypeClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Awnser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Questionid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Questionid")
                        .IsUnique();

                    b.ToTable("TextTypeClass");
                });

            modelBuilder.Entity("ApplicationForm.Entity.BooleanTypeClass", b =>
                {
                    b.HasOne("ApplicationForm.Entity.Question", "question")
                        .WithOne("Booltypeclass")
                        .HasForeignKey("ApplicationForm.Entity.BooleanTypeClass", "Questionid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("question");
                });

            modelBuilder.Entity("ApplicationForm.Entity.DropDownClass", b =>
                {
                    b.HasOne("ApplicationForm.Entity.Question", null)
                        .WithOne("DropDownClass")
                        .HasForeignKey("ApplicationForm.Entity.DropDownClass", "Questionid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationForm.Entity.Question", b =>
                {
                    b.HasOne("ApplicationForm.Entity.FormNumber", "FormNumber")
                        .WithMany("Questions")
                        .HasForeignKey("FormNumberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FormNumber");
                });

            modelBuilder.Entity("ApplicationForm.Entity.TextTypeClass", b =>
                {
                    b.HasOne("ApplicationForm.Entity.Question", null)
                        .WithOne("TextTypesclass")
                        .HasForeignKey("ApplicationForm.Entity.TextTypeClass", "Questionid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationForm.Entity.FormNumber", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("ApplicationForm.Entity.Question", b =>
                {
                    b.Navigation("Booltypeclass");

                    b.Navigation("DropDownClass");

                    b.Navigation("TextTypesclass");
                });
#pragma warning restore 612, 618
        }
    }
}
