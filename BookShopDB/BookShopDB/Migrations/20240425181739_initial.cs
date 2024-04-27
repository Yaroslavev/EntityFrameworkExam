using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookShopDB.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Author = table.Column<int>(type: "int", nullable: false),
                    Production = table.Column<int>(type: "int", nullable: false),
                    Numberofpages = table.Column<int>(name: "Number of pages", type: "int", nullable: false),
                    Genre = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Originalcost = table.Column<double>(name: "Original cost, $", type: "float", nullable: false),
                    Sellingcost = table.Column<double>(name: "Selling cost, $", type: "float", nullable: false),
                    Iscontinuation = table.Column<bool>(name: "Is continuation?", type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_Author",
                        column: x => x.Author,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Genres_Genre",
                        column: x => x.Genre,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Productions_Production",
                        column: x => x.Production,
                        principalTable: "Productions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, "Hillary", "Mantel" },
                    { 2, "F. Scott", "Fitzgerald" },
                    { 3, "Bret", "Easton Ellis" },
                    { 4, "George", "Orwell" },
                    { 5, "Cormac", "McCarthy" },
                    { 6, "Harper", "Lee" },
                    { 7, "Herman", "Melville" },
                    { 8, "Ken", "Kesey" },
                    { 9, "Joseph", "Heller" },
                    { 10, "Gabriel", "García Márquez" },
                    { 11, "Nicolas", "Sparks" },
                    { 12, "Agatha", "Christie" },
                    { 13, "Stephen", "King" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Horror" },
                    { 2, "Fantasy" },
                    { 3, "Crime" },
                    { 4, "Satire" },
                    { 5, "Historical Fiction" },
                    { 6, "Alternate History" },
                    { 7, "Adventure" },
                    { 8, "Apocalyptic" },
                    { 9, "Psychological Fiction" },
                    { 10, "Comedy" },
                    { 11, "Tragedy" },
                    { 12, "Romance" },
                    { 13, "Thriller" }
                });

            migrationBuilder.InsertData(
                table: "Productions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Penguin Random House" },
                    { 2, "Harper Collins" },
                    { 3, "Simon and Schuster" },
                    { 4, "Macmillian Publishers" },
                    { 5, "Hachette Book Group" },
                    { 6, "John Wiley and Sons" },
                    { 7, "Merriam-Webster" },
                    { 8, "Scholastic" },
                    { 9, "Pearson" },
                    { 10, "Houghton Mifflin Harcourt" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Selling cost, $", "Original cost, $", "Genre", "Is continuation?", "Title", "Number of pages", "Production", "Year" },
                values: new object[,]
                {
                    { 1, 7, 14.970000000000001, 17.969999999999999, 7, false, "Moby Dick", 378, 1, 1851 },
                    { 2, 10, 30.0, 30.0, 2, false, "One Hundred Years of Solitude", 422, 3, 1967 },
                    { 3, 1, 15.9, 19.899999999999999, 5, true, "Wolf Hall", 672, 6, 2009 },
                    { 4, 9, 89.0, 110.0, 10, false, "Catch-22", 546, 4, 1961 },
                    { 5, 6, 7.9900000000000002, 9.9900000000000002, 13, false, "To Kill a Mockingbird", 281, 5, 1960 },
                    { 6, 3, 12.99, 12.99, 4, false, "American Psycho", 399, 9, 1991 },
                    { 7, 5, 11.99, 12.99, 8, false, "The Road", 287, 10, 2006 },
                    { 8, 4, 49.899999999999999, 50.899999999999999, 6, false, "Nineteen Eighty-Four", 304, 8, 1949 },
                    { 9, 2, 0.98999999999999999, 0.98999999999999999, 11, false, "The Great Gatsby", 672, 2, 1925 },
                    { 10, 8, 8.9900000000000002, 9.9900000000000002, 9, false, "One Flew Over the Cuckoo’s Nest", 325, 7, 1962 },
                    { 11, 12, 2.4900000000000002, 2.4900000000000002, 3, false, "And Then There Were None", 272, 1, 1939 },
                    { 12, 11, 7.9900000000000002, 8.2799999999999994, 12, false, "The Notebook", 227, 3, 1996 },
                    { 13, 13, 9.9900000000000002, 9.9900000000000002, 1, false, "The Shining", 497, 8, 1977 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_Author",
                table: "Books",
                column: "Author");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Genre",
                table: "Books",
                column: "Genre");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Production",
                table: "Books",
                column: "Production");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Productions");
        }
    }
}
