using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicArtistMicroService.Models;
using MusicArtistMicroService.Repositories;
using System.Text.Json;

namespace MusicArtistMicroService.Controllers
{
    [Route("artist")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private readonly IArtistRepository artistRepository;

        public ArtistController( IArtistRepository artistRepository)
        {
            this.artistRepository = artistRepository;
        }

        [HttpGet]
        [Route("")]
        [Route("index")]
        [Route("test")]
        public Artist Index()
        {
            Artist artist = artistRepository.GetArtistById(1);
            return artist;
        }

        //[HttpGet]
        //public String Get()
        //{
        //    return "Test";
        //}
    }
}