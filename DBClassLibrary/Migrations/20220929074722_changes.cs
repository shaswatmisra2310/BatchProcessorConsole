using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBClassLibrary.Migrations
{
    public partial class changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_QuotesTable",
                table: "QuotesTable");

            migrationBuilder.AlterColumn<string>(
                name: "SymbolName",
                table: "QuotesTable",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "primarykey",
                table: "QuotesTable",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuotesTable",
                table: "QuotesTable",
                column: "primarykey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_QuotesTable",
                table: "QuotesTable");

            migrationBuilder.DropColumn(
                name: "primarykey",
                table: "QuotesTable");

            migrationBuilder.AlterColumn<string>(
                name: "SymbolName",
                table: "QuotesTable",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuotesTable",
                table: "QuotesTable",
                column: "SymbolName");
        }
    }
}
