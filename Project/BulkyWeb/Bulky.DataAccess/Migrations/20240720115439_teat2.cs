using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class teat2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.CreateTable(
			   name: "Categories",
			   columns: table => new
			   {
				   CategoryId = table.Column<int>(type: "int", nullable: false)
					   .Annotation("SqlServer:Identity", "1, 1"),
				   Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
				   DisplayOrder = table.Column<int>(type: "int", nullable: false)
			   },
			   constraints: table =>
			   {
				   table.PrimaryKey("PK_Categories", x => x.CategoryId);
			   });
			migrationBuilder.InsertData(
				table: "Categories",
				columns: new[] { "CategoryId", "DisplayOrder", "Name" },
				values: new object[,]
				{
					{ 1, 1, "Action" },
					{ 2, 2, "Sci-Fi" },
					{ 3, 3, "History" }
				});
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.DropTable(
			   name: "Categories");
		}
    }
}
