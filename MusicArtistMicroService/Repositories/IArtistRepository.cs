using MusicArtistMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicArtistMicroService.Repositories
{
    public interface IArtistRepository
    {
        IEnumerable<Artist> GetArtists();

        Artist GetArtistById(int Id);

        void InsertArtist(Artist artist);

        void UpdateArtist(Artist artist);

        void DeleteArtist(int Id );

        void Save();
    }
}
