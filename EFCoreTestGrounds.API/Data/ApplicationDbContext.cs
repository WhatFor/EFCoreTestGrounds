using EFCoreTestGrounds.API.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EFCoreTestGrounds.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opts) : base(opts) { }

        public DbSet<Game> Games { get; set; }

        public DbSet<GameReview> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>()
                .HasData(new List<Game>
                {
                    new Game
                    {
                        Id = 1,
                        Name = "DOOM",
                        ReleaseDate = new System.DateTime(1993, 12, 1),
                    },
                });

            modelBuilder.Entity<GameReview>()
                .HasData(new List<GameReview>
                {
                    new GameReview
                    {
                        Id = 1,
                        GameId = 1,
                        Stars = 5,
                        ReviewContent = "I had fun.",
                    },
                });
        }
    }
}
