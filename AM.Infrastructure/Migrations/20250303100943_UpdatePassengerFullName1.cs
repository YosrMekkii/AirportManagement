using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePassengerFullName1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullNameLast",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: false, // Make this column non-nullable
                defaultValue: "", // Optional: Set a default value
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullNameFirst",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: false, // Make this column non-nullable
                defaultValue: "", // Optional: Set a default value
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullNameLast",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: true, // Revert to nullable
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullNameFirst",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: true, // Revert to nullable
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}