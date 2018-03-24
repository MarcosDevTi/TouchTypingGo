using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TouchTypingGo.Infra.Data.Migrations
{
    public partial class Address_Institution7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Institutions_Addresses_AddressId",
                table: "Institutions");

            migrationBuilder.DropColumn(
                name: "InstitutionId",
                table: "Addresses");

            migrationBuilder.AddColumn<int>(
                name: "CascadeMode",
                table: "Institutions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CascadeMode",
                table: "Addresses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Institutions_Addresses_AddressId",
                table: "Institutions",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Institutions_Addresses_AddressId",
                table: "Institutions");

            migrationBuilder.DropColumn(
                name: "CascadeMode",
                table: "Institutions");

            migrationBuilder.DropColumn(
                name: "CascadeMode",
                table: "Addresses");

            migrationBuilder.AddColumn<Guid>(
                name: "InstitutionId",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Institutions_Addresses_AddressId",
                table: "Institutions",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
