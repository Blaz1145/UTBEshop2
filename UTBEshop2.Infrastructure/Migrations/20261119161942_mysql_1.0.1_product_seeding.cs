using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UTBEshop2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mysql_101_product_seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "najlepsi rohlik na svete", "/img/products/produkty-01.jpg", "Rohlik", 2.0 },
                    { 2, "nejlepší chleba v galaxii", "/img/products/produkty-02.jpg", "Chleba", 50.0 },
                    { 3, "nejlepší bageta ve vesmíru", "/img/products/produkty-05.jpg", "Bageta", 40.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
