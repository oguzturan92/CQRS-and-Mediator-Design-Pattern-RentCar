using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CQRS_Mediator_Car.Migrations
{
    public partial class start2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CarDescription",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarImage",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarDescription",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CarImage",
                table: "Cars");
        }
    }
}
