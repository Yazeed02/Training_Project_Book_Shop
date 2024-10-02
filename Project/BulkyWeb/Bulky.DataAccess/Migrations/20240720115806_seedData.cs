using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.InsertData(
				table: "Categories",
				columns: new[] { "CategoryId", "DisplayOrder", "Name" },
				values: new object[,]
				{
					{ 1, 1, "Action" },
					{ 2, 2, "Sci-Fi" },
					{ 3, 3, "History" },
					{ 4, 4, "Drama" }
				});
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
