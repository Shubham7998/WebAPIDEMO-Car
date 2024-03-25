using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.API.Migrations
{
    /// <inheritdoc />
    public partial class tableCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CarType",
                table: "Cars",
                newName: "CarTypeId");

            migrationBuilder.CreateTable(
                name: "CarTypes",
                columns: table => new
                {
                    CarTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarTypes", x => x.CarTypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarTypeId",
                table: "Cars",
                column: "CarTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarTypes_CarTypeId",
                table: "Cars",
                column: "CarTypeId",
                principalTable: "CarTypes",
                principalColumn: "CarTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarTypes_CarTypeId",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "CarTypes");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CarTypeId",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "CarTypeId",
                table: "Cars",
                newName: "CarType");
        }
    }
}
