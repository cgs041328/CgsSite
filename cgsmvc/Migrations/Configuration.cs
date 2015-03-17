using cgsmvc.Models;

namespace cgsmvc.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<cgsmvc.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(cgsmvc.Models.MovieDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Movies.AddOrUpdate(i=>i.Title,
                new Movie
                {
                    Title = "When",
                    ReleaseDate = DateTime.Parse("1981-1-1"),
                    Genre = "Roman Comedy",
                    Price = 7.99M,
                    Rating = "PG"
                },
                 new Movie
                {
                    Title = "Where",
                    ReleaseDate = DateTime.Parse("1983-1-1"),
                    Genre = " Comedy",
                    Price = 3.99M,
                    Rating = "PG"
                }
                );
        }
    }
}
