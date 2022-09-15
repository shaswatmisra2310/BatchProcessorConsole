using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBClassLibrary.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuotesTable",
                columns: table => new
                {
                    SymbolName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuoteType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Industry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Exchange = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuotesTable", x => x.SymbolName);
                });

            migrationBuilder.CreateTable(
                name: "SymbolConfigTable",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SymbolName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SymbolConfigTable", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "HeaderTable",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Host = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    symbolConfigKey = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeaderTable", x => x.Key);
                    table.ForeignKey(
                        name: "FK_HeaderTable_SymbolConfigTable_symbolConfigKey",
                        column: x => x.symbolConfigKey,
                        principalTable: "SymbolConfigTable",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeaderTable_symbolConfigKey",
                table: "HeaderTable",
                column: "symbolConfigKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeaderTable");

            migrationBuilder.DropTable(
                name: "QuotesTable");

            migrationBuilder.DropTable(
                name: "SymbolConfigTable");
        }
    }
}
