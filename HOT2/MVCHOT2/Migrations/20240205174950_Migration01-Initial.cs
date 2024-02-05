using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVCHOT2.Migrations
{
    /// <inheritdoc />
    public partial class Migration01Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestProducts",
                columns: table => new
                {
                    TestProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescShort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescLong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<double>(type: "float", nullable: false),
                    ProductQuantity = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestProducts", x => x.TestProductId);
                });

            migrationBuilder.InsertData(
                table: "TestProducts",
                columns: new[] { "TestProductId", "Category", "ProductDescLong", "ProductDescShort", "ProductImage", "ProductName", "ProductPrice", "ProductQuantity" },
                values: new object[,]
                {
                    { 1, "4", "", " ", "", "AeroFlo ATB Wheels", 189.0, 40 },
                    { 2, "1", "", " ", "", "Clear Shade 85-T Glasses", 45.0, 14 },
                    { 3, "4", "", " ", "", "Cosmic Elite Road Warrior Wheels", 165.0, 22 },
                    { 4, "1", "", " ", "", "Cycle-Doc Pro Repair Stand", 166.0, 12 },
                    { 5, "1", "", " ", "", "Dog Ear Aero-Flow Floor Pump", 5.0, 25 },
                    { 6, "1", "", " ", "", "Dog Ear Cycle Computer", 75.0, 20 },
                    { 7, "1", "", " ", "", "Dog Ear Helmet Mount Mirrors", 7.4500000000000002, 12 },
                    { 8, "1", "", " ", "", "Dog Ear Monster Grip Gloves", 15.0, 30 },
                    { 9, "2", "", " ", "", "Eagle FS-3 Mountain Bike", 1800.0, 8 },
                    { 10, "4", "", " ", "", "Eagle SA-120 Clipless Pedals", 139.94999999999999, 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestProducts");
        }
    }
}
