using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiEcommerce.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "usr",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "usr",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "usr",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "usr",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "usr",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "usr",
                newName: "email");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "phone",
                table: "usr",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "usr",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "usr",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "usr",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "usr",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "usr",
                newName: "Username");
        }
    }
}
