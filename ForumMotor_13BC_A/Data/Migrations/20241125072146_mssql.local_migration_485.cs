using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForumMotor_13BC_A.Data.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_485 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KeresztNev",
                table: "AspNetUsers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VezetekNev",
                table: "AspNetUsers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KeresztNev",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "VezetekNev",
                table: "AspNetUsers");
        }
    }
}
