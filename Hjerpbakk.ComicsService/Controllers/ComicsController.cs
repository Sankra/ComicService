﻿using System.Threading.Tasks;
using Hjerpbakk.ComicsService.Clients;
using Microsoft.AspNetCore.Mvc;

namespace Hjerpbakk.ComicService.Controllers
{
    [Route("api/[controller]")]
    public class ComicsController : Controller
    {
        readonly ComicsClient comicsClient;

        public ComicsController(ComicsClient comicsClient)
        {
            this.comicsClient = comicsClient;
        }

        [HttpGet]
        public async Task<string> Get() => await comicsClient.GetLatestComicAsync();

		[HttpGet("random")]
        public async Task<string> GetRandom() => await comicsClient.GetLatestComicFromRandomFeedAsync();
        // TODO: enable listing of available comics
    }
}
