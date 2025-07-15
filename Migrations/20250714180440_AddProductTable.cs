using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiEcommerce.Migrations
{
    /// <inheritdoc />
    public partial class AddProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "product",
                newName: "stock");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "product",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "product",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "product",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "product",
                newName: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "stock",
                table: "product",
                newName: "Stock");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "product",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "product",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "product",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "product",
                newName: "Id");
        }
    }
}
