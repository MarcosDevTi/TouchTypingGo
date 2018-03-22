using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TouchTypingGo.Infra.Data.Migrations
{
    public partial class Ajusment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_lessonResult_lessonPresentation_lessonPresentationId",
                table: "LessonResult");

            migrationBuilder.DropPrimaryKey(
                name: "PK_lessonResult",
                table: "LessonResult");

            migrationBuilder.DropPrimaryKey(
                name: "PK_lessonPresentation",
                table: "LessonPresentation");

            migrationBuilder.RenameTable(
                name: "LessonResult",
                newName: "LessonResult");

            migrationBuilder.RenameTable(
                name: "LessonPresentation",
                newName: "LessonPresentation");

            migrationBuilder.RenameIndex(
                name: "IX_lessonResult_lessonPresentationId",
                table: "LessonResult",
                newName: "IX_LessonResult_lessonPresentationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LessonResult",
                table: "LessonResult",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LessonPresentation",
                table: "LessonPresentation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonResult_LessonPresentation_lessonPresentationId",
                table: "LessonResult",
                column: "lessonPresentationId",
                principalTable: "LessonPresentation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonResult_LessonPresentation_lessonPresentationId",
                table: "LessonResult");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LessonResult",
                table: "LessonResult");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LessonPresentation",
                table: "LessonPresentation");

            migrationBuilder.RenameTable(
                name: "LessonResult",
                newName: "LessonResult");

            migrationBuilder.RenameTable(
                name: "LessonPresentation",
                newName: "LessonPresentation");

            migrationBuilder.RenameIndex(
                name: "IX_LessonResult_lessonPresentationId",
                table: "LessonResult",
                newName: "IX_lessonResult_lessonPresentationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_lessonResult",
                table: "LessonResult",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_lessonPresentation",
                table: "LessonPresentation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_lessonResult_lessonPresentation_lessonPresentationId",
                table: "LessonResult",
                column: "lessonPresentationId",
                principalTable: "LessonPresentation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
