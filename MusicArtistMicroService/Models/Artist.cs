using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicArtistMicroService.Models
{
    public class Artist
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public Genre Genre { get; set; }
    }
}
