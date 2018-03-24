using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TouchTypingGo.Infra.Data.Migrations
{
    public partial class Address_Institution4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Institutions_InstitutionId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_InstitutionId",
                table: "Addresses");

            migrationBuilder.CreateIndex(
                name: "IX_Institutions_AddressId",
                table: "Institutions",
                column: "AddressId",
                unique: true,
                filter: "[AddressId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Institutions_Addresses_AddressId",
                table: "Institutions",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Institutions_Addresses_AddressId",
                table: "Institutions");

            migrationBuilder.DropIndex(
                name: "IX_Institutions_AddressId",
                table: "Institutions");

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
    }
}
