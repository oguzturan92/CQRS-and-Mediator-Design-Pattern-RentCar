using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CQRS_Mediator_Car.Migrations
{
    public partial class start3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeatureAge",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "FeatureAutomaticTransmission",
                table: "Features");

            migrationBuilder.AddColumn<string>(
                name: "FeatureAutomaticTransmission",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeatureAutomaticTransmission",
                table: "Cars");

            migrationBuilder.AddColumn<string>(
                name: "FeatureAge",
                table: "Features",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeatureAutomaticTransmission",
                table: "Features",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
