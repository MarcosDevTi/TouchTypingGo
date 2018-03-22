using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TouchTypingGo.Infra.Data.Migrations
{
    public partial class Ajusment2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonResult_LessonPresentation_lessonPresentationId",
                table: "LessonResult");

            migrationBuilder.RenameColumn(
                name: "lessonPresentationId",
                table: "LessonResult",
                newName: "LessonPresentationId");

            migrationBuilder.RenameIndex(
                name: "IX_LessonResult_lessonPresentationId",
                table: "LessonResult",
                newName: "IX_LessonResult_LessonPresentationId");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonResult_LessonPresentation_LessonPresentationId",
                table: "LessonResult",
                column: "LessonPresentationId",
                principalTable: "LessonPresentation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonResult_LessonPresentation_LessonPresentationId",
                table: "LessonResult");

            migrationBuilder.RenameColumn(
                name: "LessonPresentationId",
                table: "LessonResult",
                newName: "lessonPresentationId");

            migrationBuilder.RenameIndex(
                name: "IX_LessonResult_LessonPresentationId",
                table: "LessonResult",
                newName: "IX_LessonResult_lessonPresentationId");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonResult_LessonPresentation_lessonPresentationId",
                table: "LessonResult",
                column: "lessonPresentationId",
                principalTable: "LessonPresentation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
