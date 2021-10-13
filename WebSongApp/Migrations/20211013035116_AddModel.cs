using Microsoft.EntityFrameworkCore.Migrations;

namespace WebSongApp.Migrations
{
    public partial class AddModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cancion",
                columns: table => new
                {
                    Cancion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Letra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enlace = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cancion", x => x.Cancion);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cancion");
        }
    }
}
