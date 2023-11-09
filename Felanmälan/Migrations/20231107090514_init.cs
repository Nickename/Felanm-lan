using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ErrorReport.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Felanmälningar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rubrik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Innehåll = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sammanfattning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Återskapande = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Felanmälningar", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Felanmälningar");
        }
    }
}
