using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TouchTypingGo.Infra.Data.Migrations
{
    public partial class Address_Institution : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Institutions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddressId = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(type: "varchar(60)", nullable: false),
                    Name = table.Column<string>(type: "varchar(60)", nullable: false),
                    Phone = table.Column<string>(type: "varchar(40)", nullable: false),
                    UserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institutions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    City = table.Column<string>(type: "varchar(40)", nullable: false),
                    County = table.Column<string>(type: "varchar(40)", nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    InstitutionId = table.Column<Guid>(nullable: false),
                    Number = table.Column<string>(type: "varchar(10)", nullable: true),
                    Street = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true),
                    ZipCode = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Institutions_InstitutionId",
                        column: x => x.InstitutionId,
                        principalTable: "Institutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_InstitutionId",
                table: "Addresses",
                column: "InstitutionId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Institutions");
        }
    }
}
