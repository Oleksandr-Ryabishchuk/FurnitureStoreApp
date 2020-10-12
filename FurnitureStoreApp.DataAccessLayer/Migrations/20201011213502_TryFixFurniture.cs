using Microsoft.EntityFrameworkCore.Migrations;

namespace FurnitureStoreApp.DataAccessLayer.Migrations
{
    public partial class TryFixFurniture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lenth",
                table: "Furnitures");

            migrationBuilder.AddColumn<int>(
                name: "Length",
                table: "Furnitures",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Length",
                table: "Furnitures");

            migrationBuilder.AddColumn<int>(
                name: "Lenth",
                table: "Furnitures",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
