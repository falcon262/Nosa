using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PwC.Nosa.Migrations
{
    /// <inheritdoc />
    public partial class AddedLOSToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LOS",
                table: "AbpUsers",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LOS",
                table: "AbpUsers");
        }
    }
}
