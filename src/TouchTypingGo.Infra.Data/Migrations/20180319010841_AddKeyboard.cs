using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TouchTypingGo.Infra.Data.Migrations
{
    public partial class AddKeyboard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Keyboard",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    KeyboardContent = table.Column<string>(nullable: true),
                    Lcid = table.Column<int>(nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", nullable: true),
                    ValHtml = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keyboard", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Keyboard");
        }
    }
}
