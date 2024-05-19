using BlazorServer.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Author>().HasData(
                new Author { AuthorID = 1, Name = "J.K. Rowling", Bio = "British author, best known for the Harry Potter series.", Nationality = "British" },
                new Author { AuthorID = 2, Name = "George R.R. Martin", Bio = "American novelist and short story writer, best known for A Song of Ice and Fire.", Nationality = "American" },
                new Author { AuthorID = 3, Name = "J.R.R. Tolkien", Bio = "English writer, poet, philologist, and academic, best known for The Lord of the Rings.", Nationality = "British" }
            );

            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreID = 1, Name = "Fantasy" },
                new Genre { GenreID = 2, Name = "Science Fiction" },
                new Genre { GenreID = 3, Name = "Mystery" }
            );

            modelBuilder.Entity<Publisher>().HasData(
               new Publisher { PublisherID = 1, Name = "Bloomsbury", Description = "A leading independent publishing house." },
               new Publisher { PublisherID = 2, Name = "Bantam Books", Description = "An American publishing house owned entirely by Penguin Random House." },
               new Publisher { PublisherID = 3, Name = "HarperCollins", Description = "One of the world's largest publishing companies." }
           );


            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookID = 1,
                    Title = "Harry Potter and the Philosopher's Stone",
                    AuthorID = 1,
                    ISBN = "978-0747532699",
                    GenreID = 1,
                    PublisherID = 1,
                    PublishDate = new DateTime(1997, 6, 26),
                    QuantityAvailable = 10,
                    Description = "The first book in the Harry Potter series."
                },
                new Book
                {
                    BookID = 2,
                    Title = "A Game of Thrones",
                    AuthorID = 2,
                    ISBN = "978-0553103540",
                    GenreID = 1,
                    PublisherID = 2,
                    PublishDate = new DateTime(1996, 8, 6),
                    QuantityAvailable = 5,
                    Description = "The first book in A Song of Ice and Fire series."
                },
                new Book
                {
                    BookID = 3,
                    Title = "The Hobbit",
                    AuthorID = 3,
                    ISBN = "978-0261102217",
                    GenreID = 1,
                    PublisherID = 3,
                    PublishDate = new DateTime(1937, 9, 21),
                    QuantityAvailable = 8,
                    Description = "A fantasy novel and children's book by J.R.R. Tolkien."
                }
            );
        }
    }
}
