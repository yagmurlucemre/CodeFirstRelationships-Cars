using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ANK17CodeFirstRelationships.Migrations
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_LicensePlates_LicensePlateId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Person_PersonId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_LicensePlateId",
                table: "Cars");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Cars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LicensePlateId",
                table: "Cars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_LicensePlateId",
                table: "Cars",
                column: "LicensePlateId",
                unique: true,
                filter: "[LicensePlateId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_LicensePlates_LicensePlateId",
                table: "Cars",
                column: "LicensePlateId",
                principalTable: "LicensePlates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Person_PersonId",
                table: "Cars",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_LicensePlates_LicensePlateId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Person_PersonId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_LicensePlateId",
                table: "Cars");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LicensePlateId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_LicensePlateId",
                table: "Cars",
                column: "LicensePlateId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_LicensePlates_LicensePlateId",
                table: "Cars",
                column: "LicensePlateId",
                principalTable: "LicensePlates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Person_PersonId",
                table: "Cars",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
