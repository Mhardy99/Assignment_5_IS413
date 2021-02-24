using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_5_IS413.Models
{
    public class SeedData
    { //the seed data that I am going to enter into the database
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            FakeAmazonDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<FakeAmazonDbContext>();
            if(context.Database.GetPendingMigrations().Any())
            { //migrates if there are any necessary migrations
                context.Database.Migrate();
            }

            if (!context.Projects.Any())
            {
                context.Projects.AddRange(
                    new Project
                    {
                        Title = "Les Miserables",
                        Author = "Victor",
                        AuthorMiddle = "",
                        AuthorLast = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Category = "Classic",
                        Classification = "Fiction",
                        PageNum = 1488,
                        Price = 9.95
                        

                    },
                    new Project
                    {
                        Title = "Team of Rivals",
                        Author = "Doris",
                        AuthorMiddle = "Kearns",
                        AuthorLast = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Category = "Biography",
                        Classification = "Non-Fiction",
                        PageNum = 944,
                        Price = 14.58

                    },
                    new Project
                    {
                        Title = "The Snowball",
                        Author = "Alice",
                        AuthorMiddle = "",
                        AuthorLast = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Category = "Biography",
                        Classification = "Non-Fiction",
                        PageNum = 832,
                        Price = 21.54

                    },
                    new Project
                    {
                        Title = "American Ulysses",
                        Author = "Ronald",
                        AuthorMiddle = "C.",
                        AuthorLast = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Category = "Biography",
                        Classification = "Non-Fiction",
                        PageNum = 864,
                        Price = 11.61

                    },
                    new Project
                    {
                        Title = "Unbroken",
                        Author = "Laura",
                        AuthorMiddle = "",
                        AuthorLast = "Hilenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Category = "Historical",
                        Classification = "Non-Fiction",
                        PageNum = 528,
                        Price = 13.33

                    },
                    new Project
                    {
                        Title = "The Great Train Robbery",
                        Author = "Laura",
                        AuthorMiddle = "",
                        AuthorLast = "Hilenbrand",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Category = "Historical Fiction",
                        Classification = "Non-Fiction",
                        PageNum = 288,
                        Price = 15.95

                    },
                    new Project
                    {
                        Title = "Deep Work",
                        Author = "Cal",
                        AuthorMiddle = "",
                        AuthorLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Category = "Self-Help",
                        Classification = "Non-Fiction",
                        PageNum = 304,
                        Price = 14.99

                    },
                    new Project
                    {
                        Title = "It's Your Ship",
                        Author = "Michael",
                        AuthorMiddle = "",
                        AuthorLast = "Abrashoff",
                        
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Category = "Self-Help",
                        Classification = "Non-Fiction",
                        PageNum = 240,
                        Price = 21.66

                    },
                    new Project
                    {
                        Title = "The Virgin Way",
                        Author = "Richard",
                        AuthorMiddle = "",
                        AuthorLast = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Category = "Business",
                        Classification = "Non-Fiction",
                        PageNum = 400,
                        Price = 29.16

                    },
                    new Project
                    {

                        Title = "Sycamore Row",
                        Author = "John",
                        AuthorMiddle = "",
                        AuthorLast = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Category = "Thrillers",
                        Classification = "Fiction",
                        PageNum = 642,
                        Price = 15.03

                    },
                    //Three new books taht were added
                    new Project
                    {

                        Title = "Way of Kings",
                        Author = "Brandon",
                        AuthorMiddle = "",
                        AuthorLast = "Sanderson",
                        Publisher = "Tor Books",
                        ISBN = "978-0765326355",
                        Category = "High Fantasy",
                        Classification = "Fiction",
                        PageNum = 1007,
                        Price = 9.89

                    },
                    new Project
                    {

                        Title = "Red Rising",
                        Author = "Pierce",
                        AuthorMiddle = "",
                        AuthorLast = "Brown",
                        Publisher = "Del Rey Books",
                        ISBN = "978-0765326355",
                        Category = "Science Fiction",
                        Classification = "Fiction",
                        PageNum = 382,
                        Price = 10.15

                    },
                    new Project
                    {

                        Title = "Memories of Ice",
                        Author = "Steven",
                        AuthorMiddle = "",
                        AuthorLast = "Erikson",
                        Publisher = "Tor Books",
                        ISBN = "978-0765326355",
                        Category = "High Fantasy",
                        Classification = "Fiction",
                        PageNum = 1187,
                        Price = 9.99

                    }




                    ); //save changes to the database
                context.SaveChanges();
            }
        }
    }
}
