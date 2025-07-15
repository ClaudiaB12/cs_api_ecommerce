using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiEcommerce.Migrations
{
    /// <inheritdoc />
    public partial class AddCartTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cart_product_productNavid",
                table: "cart");

            migrationBuilder.DropForeignKey(
                name: "FK_cart_usr_userNavid",
                table: "cart");

            migrationBuilder.DropIndex(
                name: "IX_cart_productNavid",
                table: "cart");

            migrationBuilder.DropIndex(
                name: "IX_cart_userNavid",
                table: "cart");

            migrationBuilder.DropColumn(
                name: "productNavid",
                table: "cart");

            migrationBuilder.DropColumn(
                name: "userNavid",
                table: "cart");

            migrationBuilder.CreateIndex(
                name: "IX_cart_client",
                table: "cart",
                column: "client");

            migrationBuilder.CreateIndex(
                name: "IX_cart_product",
                table: "cart",
                column: "product");

            migrationBuilder.AddForeignKey(
                name: "FK_cart_product_product",
                table: "cart",
                column: "product",
                principalTable: "product",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cart_usr_client",
                table: "cart",
                column: "client",
                principalTable: "usr",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cart_product_product",
                table: "cart");

            migrationBuilder.DropForeignKey(
                name: "FK_cart_usr_client",
                table: "cart");

            migrationBuilder.DropIndex(
                name: "IX_cart_client",
                table: "cart");

            migrationBuilder.DropIndex(
                name: "IX_cart_product",
                table: "cart");

            migrationBuilder.AddColumn<int>(
                name: "productNavid",
                table: "cart",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "userNavid",
                table: "cart",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_cart_productNavid",
                table: "cart",
                column: "productNavid");

            migrationBuilder.CreateIndex(
                name: "IX_cart_userNavid",
                table: "cart",
                column: "userNavid");

            migrationBuilder.AddForeignKey(
                name: "FK_cart_product_productNavid",
                table: "cart",
                column: "productNavid",
                principalTable: "product",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_cart_usr_userNavid",
                table: "cart",
                column: "userNavid",
                principalTable: "usr",
                principalColumn: "id");
        }
    }
}
