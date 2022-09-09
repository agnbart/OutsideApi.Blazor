using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OutsideApi.BlazorServerApp.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Booki",
                columns: table => new
                {
                    kind = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    full_sort_key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cover_color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cover = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    epoch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    href = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    has_audio = table.Column<bool>(type: "bit", nullable: false),
                    genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    simple_thumb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cover_thumb = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booki");
        }
    }
}
