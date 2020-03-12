using Microsoft.EntityFrameworkCore;
using MusicArtistMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicArtistMicroService.DBContexts
{

    public class ArtistContext : DbContext
    {
        public ArtistContext( DbContextOptions<ArtistContext> options ) : base(options)
        {

        }

        public DbSet<Artist> Artists { get; set; }

        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            modelBuilder.Entity<Artist>().HasData(
                new Artist
                {
                    Id = 1,
                    Name = "Beatles",
                    Genre = Genre.Rock
                },
                new Artist
                {
                    Id = 2,
                    Name = "Rolling Stones",
                    Genre = Genre.Rock
                }
            );
        }
    }
}
