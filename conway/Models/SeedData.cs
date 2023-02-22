using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using conway.Data;
using System;
using System.Linq;

namespace conway.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new conwayContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<conwayContext>>()))
        {
            // Look for any movies.
            if (context.Conway.Any())
            {
                return;   // DB has been seeded
            }
            context.Conway.AddRange(
                new Conway
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "R"
                },
                new Conway
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M,
                    Rating = "PG-13"
                },
                new Conway
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M,
                    Rating = "PG-13"
                },
                new Conway
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M,
                    Rating = "PG-13"
                },
                new Conway
                {
                    Title = "The Lion King",
                    ReleaseDate = DateTime.Parse("1998-4-15"),
                    Genre = "Adventure",
                    Price = 4.99M,
                    Rating = "PG"
                },
                new Conway
                {
                    Title = "The Little Mermaid",
                    ReleaseDate = DateTime.Parse("1995-4-15"),
                    Genre = "Adventure",
                    Price = 69.99M,
                    Rating = "PG"
                },
                new Conway
                {
                    Title = "Smidge",
                    ReleaseDate = DateTime.Parse("2020-5-12"),
                    Genre = "Horror",
                    Price = 1223.99M,
                    Rating = "X"
                }
            );
            context.SaveChanges();
        }
    }
}