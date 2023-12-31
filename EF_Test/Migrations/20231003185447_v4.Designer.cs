﻿// <auto-generated />
using EF_Test;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_Test.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231003185447_v4")]
    partial class v4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EF_Test.Corse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Corses");
                });

            modelBuilder.Entity("EF_Test.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EF_Test.StudentCorse", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CorseId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CorseId");

                    b.HasIndex("CorseId");

                    b.ToTable("StudentCorses");
                });

            modelBuilder.Entity("EF_Test.StudentCorse", b =>
                {
                    b.HasOne("EF_Test.Corse", "Corse")
                        .WithMany("StudentCorse")
                        .HasForeignKey("CorseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_Test.Student", "Student")
                        .WithMany("StudentCorse")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Corse");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EF_Test.Corse", b =>
                {
                    b.Navigation("StudentCorse");
                });

            modelBuilder.Entity("EF_Test.Student", b =>
                {
                    b.Navigation("StudentCorse");
                });
#pragma warning restore 612, 618
        }
    }
}
