﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TouchTypingGo.Infra.Data.Context;

namespace TouchTypingGo.Infra.Data.Migrations
{
    [DbContext(typeof(TouchTypingGoContext))]
    [Migration("20180316035846_UpgradeClassTeacher")]
    partial class UpgradeClassTeacher
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TouchTypingGo.Domain.Course.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime?>("LimitDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<Guid>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("TouchTypingGo.Domain.Course.LeconPresentation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("FontSize");

                    b.Property<int>("PrecisionReference");

                    b.Property<int>("SpeedReference");

                    b.Property<string>("Text");

                    b.Property<int>("TimeReference");

                    b.HasKey("Id");

                    b.ToTable("LeconPresentation");
                });

            modelBuilder.Entity("TouchTypingGo.Domain.Course.LeconResult", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int>("CourseId");

                    b.Property<bool>("EhAuthenticated");

                    b.Property<string>("ErrorKey")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<int>("Errors");

                    b.Property<Guid>("LeconPresentationId");

                    b.Property<int>("Time");

                    b.Property<int>("Try");

                    b.Property<int>("Wpm");

                    b.HasKey("Id");

                    b.HasIndex("LeconPresentationId");

                    b.ToTable("LeconResult");
                });

            modelBuilder.Entity("TouchTypingGo.Domain.Course.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("TouchTypingGo.Domain.Course.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("TouchTypingGo.Domain.Course.Course", b =>
                {
                    b.HasOne("TouchTypingGo.Domain.Course.Teacher", "Teacher")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TouchTypingGo.Domain.Course.LeconResult", b =>
                {
                    b.HasOne("TouchTypingGo.Domain.Course.LeconPresentation", "LeconPresentation")
                        .WithMany("LeconResults")
                        .HasForeignKey("LeconPresentationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
