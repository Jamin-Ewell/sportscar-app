using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewCars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Make", "Model" },
                values: new object[] { "Honda", "Accord Sport" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Make", "Model", "Year" },
                values: new object[] { "Hyundai", "Sonata", 2015 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "IsRented", "Make", "Model", "Year" },
                values: new object[,]
                {
                    { 3, false, "BMW", "500 Series", 2022 },
                    { 4, false, "Mercedes", "Benz", 2024 },
                    { 5, false, "Fiat", "500", 2019 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Make", "Model" },
                values: new object[] { "MakeOfSportster3000", "Sportster 3000" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Make", "Model", "Year" },
                values: new object[] { "MakeOfEcoHatch1", "EcoHatch 1", 2020 });
        }
    }
}
