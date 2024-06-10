using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CQRS_Mediator_Car.Migrations
{
    public partial class start5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CarFuelType",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarFuelType",
                table: "Cars");
        }
    }
}
