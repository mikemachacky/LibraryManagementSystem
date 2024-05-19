using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServer.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorID", "Bio", "Name", "Nationality" },
                values: new object[,]
                {
                    { 1, "British author, best known for the Harry Potter series.", "J.K. Rowling", "British" },
                    { 2, "American novelist and short story writer, best known for A Song of Ice and Fire.", "George R.R. Martin", "American" },
                    { 3, "English writer, poet, philologist, and academic, best known for The Lord of the Rings.", "J.R.R. Tolkien", "British" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreID", "Name" },
                values: new object[,]
                {
                    { 1, "Fantasy" },
                    { 2, "Science Fiction" },
                    { 3, "Mystery" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "A leading independent publishing house.", "Bloomsbury" },
                    { 2, "An American publishing house owned entirely by Penguin Random House.", "Bantam Books" },
                    { 3, "One of the world's largest publishing companies.", "HarperCollins" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "AuthorID", "Description", "GenreID", "ISBN", "PublishDate", "PublisherID", "QuantityAvailable", "Title" },
                values: new object[,]
                {
                    { 1, 1, "The first book in the Harry Potter series.", 1, "978-0747532699", new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 10, "Harry Potter and the Philosopher's Stone" },
                    { 2, 2, "The first book in A Song of Ice and Fire series.", 1, "978-0553103540", new DateTime(1996, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 5, "A Game of Thrones" },
                    { 3, 3, "A fantasy novel and children's book by J.R.R. Tolkien.", 1, "978-0261102217", new DateTime(1937, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 8, "The Hobbit" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PublisherID",
                keyValue: 3);
        }
    }
}
