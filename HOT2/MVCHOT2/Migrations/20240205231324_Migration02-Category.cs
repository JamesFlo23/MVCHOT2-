using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVCHOT2.Migrations
{
    /// <inheritdoc />
    public partial class Migration02Category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "TestProducts");

            migrationBuilder.AddColumn<string>(
                name: "CategoryId",
                table: "TestProducts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "ACC", "Accessories" },
                    { "BIK", "Bikes" },
                    { "CAR", "Car racks" },
                    { "CLO", "Clothing" },
                    { "COM", "Components" },
                    { "WHE", "Wheels" }
                });

            migrationBuilder.UpdateData(
                table: "TestProducts",
                keyColumn: "TestProductId",
                keyValue: 1,
                column: "CategoryId",
                value: "COM");

            migrationBuilder.UpdateData(
                table: "TestProducts",
                keyColumn: "TestProductId",
                keyValue: 2,
                column: "CategoryId",
                value: "ACC");

            migrationBuilder.UpdateData(
                table: "TestProducts",
                keyColumn: "TestProductId",
                keyValue: 3,
                column: "CategoryId",
                value: "COM");

            migrationBuilder.UpdateData(
                table: "TestProducts",
                keyColumn: "TestProductId",
                keyValue: 4,
                column: "CategoryId",
                value: "ACC");

            migrationBuilder.UpdateData(
                table: "TestProducts",
                keyColumn: "TestProductId",
                keyValue: 5,
                column: "CategoryId",
                value: "ACC");

            migrationBuilder.UpdateData(
                table: "TestProducts",
                keyColumn: "TestProductId",
                keyValue: 6,
                column: "CategoryId",
                value: "ACC");

            migrationBuilder.UpdateData(
                table: "TestProducts",
                keyColumn: "TestProductId",
                keyValue: 7,
                column: "CategoryId",
                value: "ACC");

            migrationBuilder.UpdateData(
                table: "TestProducts",
                keyColumn: "TestProductId",
                keyValue: 8,
                column: "CategoryId",
                value: "ACC");

            migrationBuilder.UpdateData(
                table: "TestProducts",
                keyColumn: "TestProductId",
                keyValue: 9,
                column: "CategoryId",
                value: "BIK");

            migrationBuilder.UpdateData(
                table: "TestProducts",
                keyColumn: "TestProductId",
                keyValue: 10,
                column: "CategoryId",
                value: "COM");

            migrationBuilder.CreateIndex(
                name: "IX_TestProducts_CategoryId",
                table: "TestProducts",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestProducts_Categories_CategoryId",
                table: "TestProducts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestProducts_Categories_CategoryId",
                table: "TestProducts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_TestProducts_CategoryId",
                table: "TestProducts");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "TestProducts");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "TestProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "TestProducts",
                keyColumn: "TestProductId",
                keyValue: 1,
                column: "Category",
                value: "4");

            migrationBuilder.UpdateData(
                table: "TestProducts",
                keyColumn: "TestProductId",
                keyValue: 2,
                column: "Category",
                value: "1");

            migrationBuilder.UpdateData(
                table: "TestProducts",
                keyColumn: "TestProductId",
                keyValue: 3,
                column: "Category",
                value: "4");

            migrationBuilder.UpdateData(
                table: "TestProducts",
                keyColumn: "TestProductId",
                keyValue: 4,
                column: "Category",
                value: "1");

            migrationBuilder.UpdateData(
                table: "TestProducts",
                keyColumn: "TestProductId",
                keyValue: 5,
                column: "Category",
                value: "1");

            migrationBuilder.UpdateData(
                table: "TestProducts",
                keyColumn: "TestProductId",
                keyValue: 6,
                column: "Category",
                value: "1");

            migrationBuilder.UpdateData(
                table: "TestProducts",
                keyColumn: "TestProductId",
                keyValue: 7,
                column: "Category",
                value: "1");

            migrationBuilder.UpdateData(
                table: "TestProducts",
                keyColumn: "TestProductId",
                keyValue: 8,
                column: "Category",
                value: "1");

            migrationBuilder.UpdateData(
                table: "TestProducts",
                keyColumn: "TestProductId",
                keyValue: 9,
                column: "Category",
                value: "2");

            migrationBuilder.UpdateData(
                table: "TestProducts",
                keyColumn: "TestProductId",
                keyValue: 10,
                column: "Category",
                value: "4");
        }
    }
}
