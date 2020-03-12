using MusicArtistMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicArtistMicroService.DBContexts;

namespace MusicArtistMicroService.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly ArtistContext artistContext;

        public ArtistRepository( ArtistContext artistContext )
        {
            this.artistContext = artistContext;
        }

        public void DeleteArtist(int Id)
        {
            throw new NotImplementedException();
        }

        public Artist GetArtistById(int Id)
        {
            Artist artist = artistContext.Artists.Find( 1 );
            return artist;
        }

        public IEnumerable<Artist> GetArtists()
        {
            throw new NotImplementedException();
        }

        public void InsertArtist(Artist artist)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateArtist(Artist artist)
        {
            throw new NotImplementedException();
        }
    }
}
