using Microsoft.EntityFrameworkCore.Migrations;

namespace net_core_api_sabnis.Migrations
{
  public partial class Initial : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
        name: "Books",
        columns: table => new
        {
          Id = table.Column<int>(nullable: false),
          BookTitle = table.Column<string>(maxLength: 50, nullable: false),
          AuthorName = table.Column<string>(maxLength: 100, nullable: false),
          Publisher = table.Column<string>(maxLength: 100, nullable: false),
          Genre = table.Column<string>(nullable: true),
          Price = table.Column<int>(nullable: false)
        },
        constraints: table =>
        {
          table.PrimaryKey("PK_Books", x => x.Id);
        });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable( name: "Books");
    }
  }
}
