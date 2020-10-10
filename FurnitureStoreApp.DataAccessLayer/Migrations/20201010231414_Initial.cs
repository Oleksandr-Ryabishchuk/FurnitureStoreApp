using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FurnitureStoreApp.DataAccessLayer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Furnitures",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 128, nullable: false),
                    InStock = table.Column<bool>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    IsUnique = table.Column<bool>(nullable: false),
                    Width = table.Column<int>(nullable: false),
                    Lenth = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Furnitures", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Furnitures");
        }
    }
}
