using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCmovietracker.Migrations
{
    public partial class _623Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Summary",
                table: "Movie",
                type: "REAL",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "TEXT",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Summary",
                table: "Movie",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "REAL",
                oldNullable: true);
        }
    }
}
