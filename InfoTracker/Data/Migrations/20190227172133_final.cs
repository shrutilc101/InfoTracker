using Microsoft.EntityFrameworkCore.Migrations;

namespace InfoTracker.Data.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Card",
                table: "ITs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CardLast4digits",
                table: "ITs",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Cash",
                table: "ITs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Check",
                table: "ITs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DOB",
                table: "ITs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "ITs",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DriversLicense",
                table: "ITs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "ITs",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HomeAdd",
                table: "ITs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PassportDetails",
                table: "ITs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Phonenumber",
                table: "ITs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SSN",
                table: "ITs",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Card",
                table: "ITs");

            migrationBuilder.DropColumn(
                name: "CardLast4digits",
                table: "ITs");

            migrationBuilder.DropColumn(
                name: "Cash",
                table: "ITs");

            migrationBuilder.DropColumn(
                name: "Check",
                table: "ITs");

            migrationBuilder.DropColumn(
                name: "DOB",
                table: "ITs");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "ITs");

            migrationBuilder.DropColumn(
                name: "DriversLicense",
                table: "ITs");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "ITs");

            migrationBuilder.DropColumn(
                name: "HomeAdd",
                table: "ITs");

            migrationBuilder.DropColumn(
                name: "PassportDetails",
                table: "ITs");

            migrationBuilder.DropColumn(
                name: "Phonenumber",
                table: "ITs");

            migrationBuilder.DropColumn(
                name: "SSN",
                table: "ITs");
        }
    }
}
