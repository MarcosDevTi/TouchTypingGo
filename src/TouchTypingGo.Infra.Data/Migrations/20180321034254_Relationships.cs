using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TouchTypingGo.Infra.Data.Migrations
{
    public partial class Relationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Time",
                table: "LessonResult",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Errors",
                table: "LessonResult",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateTable(
                name: "CourseLessonPresentations",
                columns: table => new
                {
                    CourseId = table.Column<Guid>(nullable: false),
                    LessonPresentationId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseLessonPresentations", x => new { x.CourseId, x.LessonPresentationId });
                    table.ForeignKey(
                        name: "FK_CourseLessonPresentations_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseLessonPresentations_LessonPresentation_LessonPresentationId",
                        column: x => x.LessonPresentationId,
                        principalTable: "LessonPresentation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseLessonPresentations_LessonPresentationId",
                table: "CourseLessonPresentations",
                column: "LessonPresentationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseLessonPresentations");

            migrationBuilder.AlterColumn<int>(
                name: "Time",
                table: "LessonResult",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Errors",
                table: "LessonResult",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
