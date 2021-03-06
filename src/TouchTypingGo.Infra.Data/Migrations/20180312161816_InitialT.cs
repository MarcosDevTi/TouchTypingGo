﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TouchTypingGo.Infra.Data.Migrations
{
    public partial class InitialT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LessonPresentation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Category = table.Column<string>(type: "varchar(20)", nullable: false),
                    FontSize = table.Column<int>(nullable: false),
                    PrecisionReference = table.Column<int>(nullable: false),
                    SpeedReference = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    TimeReference = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lessonPresentation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(type: "varchar(150)", nullable: false),
                    Name = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CourseId = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(type: "varchar(150)", nullable: false),
                    Name = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LessonResult",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    CourseId = table.Column<int>(nullable: false),
                    EhAuthenticated = table.Column<bool>(nullable: false),
                    ErrorKey = table.Column<string>(type: "varchar(2)", nullable: false),
                    Errors = table.Column<int>(nullable: false),
                    lessonPresentationId = table.Column<Guid>(nullable: false),
                    Time = table.Column<int>(nullable: false),
                    Try = table.Column<int>(nullable: false),
                    Wpm = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lessonResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_lessonResult_lessonPresentation_lessonPresentationId",
                        column: x => x.lessonPresentationId,
                        principalTable: "LessonPresentation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(type: "varchar(10)", nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    LimitDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(type: "varchar(150)", nullable: false),
                    TeacherId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_lessonResult_lessonPresentationId",
                table: "LessonResult",
                column: "lessonPresentationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "LessonResult");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "LessonPresentation");
        }
    }
}
