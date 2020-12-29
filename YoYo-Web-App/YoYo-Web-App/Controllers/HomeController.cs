using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using YoYo_Web_App.IServices;
using YoYo_Web_App.Models;
using YoYo_Web_App.ViewModel;

namespace YoYoTestDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IPlayerService _playerService;


        /// <summary>Initializes a new instance of the <see cref="HomeController" /> class.</summary>
        /// <param name="logger">The logger.</param>
        /// <param name="playerService">The player service.</param>
        public HomeController(ILogger<HomeController> logger, IPlayerService playerService)
        {
            _logger = logger;
            _playerService = playerService;
        }


        /// <summary>Indexes this instance.</summary>
        /// <returns>
        ///  Index this method is used to get the list of participants in yoyo fitness test from the service <br />
        /// </returns>
        [HttpGet]
        public async  Task<IActionResult> Index()
        {
            var homeViewModel = new HomeViewModel();
            var allPlayers = await _playerService.GetPlayers().ConfigureAwait(true);

            homeViewModel.players = allPlayers;

            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
