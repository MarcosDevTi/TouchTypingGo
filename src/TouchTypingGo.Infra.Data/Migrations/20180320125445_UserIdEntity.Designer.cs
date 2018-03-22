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
    [Migration("20180320125445_UserIdEntity")]
    partial class UserIdEntity
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

                    b.Property<DateTime>("DateCreated");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime?>("LimitDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<Guid>("TeacherId");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("TouchTypingGo.Domain.Course.Keyboard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("KeyboardContent");

                    b.Property<int>("Lcid");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<Guid?>("UserId");

                    b.Property<string>("ValHtml")
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Keyboard");
                });

            modelBuilder.Entity("TouchTypingGo.Domain.Course.LessonPresentation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("DateCreated");

                    b.Property<int>("FontSize");

                    b.Property<string>("Name");

                    b.Property<int>("PrecisionReference");

                    b.Property<int>("SpeedReference");

                    b.Property<string>("Text");

                    b.Property<int>("TimeReference");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.ToTable("LessonPresentation");
                });

            modelBuilder.Entity("TouchTypingGo.Domain.Course.LessonResult", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("DateCreated");

                    b.Property<bool>("EhAuthenticated");

                    b.Property<string>("ErrorKey")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<int>("Errors");

                    b.Property<Guid>("lessonPresentationId");

                    b.Property<int>("Time");

                    b.Property<int>("Try");

                    b.Property<Guid?>("UserId");

                    b.Property<int>("Wpm");

                    b.HasKey("Id");

                    b.HasIndex("lessonPresentationId");

                    b.ToTable("LessonResult");
                });

            modelBuilder.Entity("TouchTypingGo.Domain.Course.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("TouchTypingGo.Domain.Course.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<Guid?>("UserId");

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

            modelBuilder.Entity("TouchTypingGo.Domain.Course.LessonResult", b =>
                {
                    b.HasOne("TouchTypingGo.Domain.Course.LessonPresentation", "LessonPresentation")
                        .WithMany("LessonResults")
                        .HasForeignKey("lessonPresentationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
