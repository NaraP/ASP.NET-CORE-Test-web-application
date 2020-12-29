using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YoYo_Web_App.IServices;
using YoYo_Web_App.Models;
using YoYo_Web_App.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YoYoTestDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private IPlayerService _playerService;

        /// <summary>Initializes a new instance of the <see cref="TestController" /> class.</summary>
        /// <param name="playerService">The player service.</param>
        public TestController(IPlayerService playerService)
        {
            _playerService = playerService;
        }


        /// <summary>Gets the players.</summary>
        /// <returns>
        /// GetPlayers this action method is used to get the list of yoyo fitness participants from the service  <br />
        /// </returns>
        [HttpGet("GetPlayers")]
        public ActionResult GetPlayers()
        {
            return Ok(_playerService.GetPlayers());
        }

        /// <summary>Gets the fitness rating.</summary>
        /// <returns>
        /// GetFitnessRating this action method is used to get the list of yoyo fitness ratings from the service  <br />
        /// </returns>
        [HttpGet("FitnessRating")]
        public ActionResult GetFitnessRating()
        {
            List<FitnessRating> fitnessRatingData = new List<FitnessRating>();

            try
            {
                fitnessRatingData = _playerService.GetFitnessRating().Result;
            }
            catch(Exception ex)
            {
            }
          
            return Ok(fitnessRatingData);
        }


        /// <summary>Warns the player.</summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// WarnPlayer this action method is used to warn the yoyo fitness participents from the service  <br />
        /// </returns>
        [HttpGet("WarnPlayer/{id}")]
        public async Task<ActionResult> WarnPlayer(int id)
        {
            try
            {
                var result = await _playerService.WarnPlayer(id).ConfigureAwait(false);

                return Ok(result);
            }
            catch(Exception)
            {
                return NotFound();
            }
        }


        /// <summary>Results the player.</summary>
        /// <param name="playerResultRecieved">The player result recieved.</param>
        /// <returns>
        /// ResultPlayer this action method is used to final result yoyo fitness participents from the service  <br />
        /// </returns>
        [HttpPost("ResultPlayer/{id}")]
        public ActionResult ResultPlayer([FromForm] PlayerResultViewModel playerResultRecieved)
        {
            var playerResult = _playerService.ResultPlayer(playerResultRecieved.id, playerResultRecieved.result);

            return Ok(playerResult);
        }
    }
}
