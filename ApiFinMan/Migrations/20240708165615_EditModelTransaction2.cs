using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiFinMan.Migrations
{
    /// <inheritdoc />
    public partial class EditModelTransaction2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Transactions",
                newName: "ViewType");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Transactions",
                newName: "Comment");

            migrationBuilder.RenameColumn(
                name: "Cost",
                table: "Transactions",
                newName: "Value");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ViewType",
                table: "Transactions",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Transactions",
                newName: "Cost");

            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "Transactions",
                newName: "Description");
        }
    }
}
