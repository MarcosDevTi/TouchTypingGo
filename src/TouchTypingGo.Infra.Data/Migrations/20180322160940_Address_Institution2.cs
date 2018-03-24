using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TouchTypingGo.Infra.Data.Migrations
{
    public partial class Address_Institution2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Institutions_InstitutionId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_InstitutionId",
                table: "Addresses");

            migrationBuilder.AlterColumn<Guid>(
                name: "InstitutionId",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_InstitutionId",
                table: "Addresses",
                column: "InstitutionId",
                unique: true,
                filter: "[InstitutionId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Institutions_InstitutionId",
                table: "Addresses",
                column: "InstitutionId",
                principalTable: "Institutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Institutions_InstitutionId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_InstitutionId",
                table: "Addresses");

            migrationBuilder.AlterColumn<Guid>(
                name: "InstitutionId",
                table: "Addresses",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_InstitutionId",
                table: "Addresses",
                column: "InstitutionId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Institutions_InstitutionId",
                table: "Addresses",
                column: "InstitutionId",
                principalTable: "Institutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
