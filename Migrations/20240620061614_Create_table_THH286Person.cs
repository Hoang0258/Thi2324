using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace THHBT2324.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_THH286Person : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "THH286Person",
                columns: table => new
                {
                    THH286ID = table.Column<string>(type: "TEXT", nullable: false),
                    THH286Name = table.Column<string>(type: "TEXT", nullable: false),
                    THH286DiaChi = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_THH286Person", x => x.THH286ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "THH286Person");
        }
    }
}
