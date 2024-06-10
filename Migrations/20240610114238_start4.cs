using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CQRS_Mediator_Car.Migrations
{
    public partial class start4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "CarDayPrice",
                table: "Cars",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "CarDoor",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CarLuggage",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CarPessenger",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarDayPrice",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CarDoor",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CarLuggage",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CarPessenger",
                table: "Cars");
        }
    }
}
