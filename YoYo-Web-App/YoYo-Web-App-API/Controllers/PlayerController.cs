using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoYo_Entities;
using YoYo_Logger;
using YoYo_Web_App_API.IServices;

namespace YoYo_Web_App_API.Controllers
{
    /// <summary>
    ///   <br />
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IFitnessRatingDataService _fitnessRatingDataService;
        private readonly IGetPlayerService _getPlayerService;
        private readonly IResultPlayerService _resultPlayerService;
        private readonly IWarnPlayerService _warnPlayerService;
        private readonly ILoggerManager _logger;

        /// <summary>PlayerController this constructor is initilizer for the players or participates in the test</summary>
        /// <param name="fitnessRatingDataService"></param>
        /// <param name="getPlayerService"></param>
        /// <param name="resultPlayerService"></param>
        /// <param name="warnPlayerService"></param>
        /// <param name="logger"></param>
        public PlayerController(IFitnessRatingDataService fitnessRatingDataService, IGetPlayerService getPlayerService,
               IResultPlayerService resultPlayerService, IWarnPlayerService warnPlayerService, ILoggerManager logger)
        {
            _fitnessRatingDataService = fitnessRatingDataService;
            _getPlayerService = getPlayerService;
            _resultPlayerService = resultPlayerService;
            _warnPlayerService = warnPlayerService;
            _logger = logger;
        }

        /// <summary>Gets the players.</summary>
        /// <returns>
        ///  GetPlayers this action method is used to read the list of players or participants <br />
        /// </returns>
        [HttpGet("GetPlayers")]
        public ActionResult GetPlayers()
        {
            _logger.LogInfo("Start - Get players api action mwthod");

            var players = _getPlayerService.GetPlayers();

            _logger.LogInfo("End - Get players api action mwthod");

            return Ok(players);
        }

        /// <summary>Gets the fitness rating.</summary>
        /// <returns>
        ///   GetFitnessRating this action method is used to get the yoyo fitness test ratings<br />
        /// </returns>
        [HttpGet("FitnessRating")]
        public ActionResult GetFitnessRating()
        {
            List<FitnessRating> fitnessRatingData = new List<FitnessRating>();

            try
            {
                fitnessRatingData = _fitnessRatingDataService.GetFitnessRatingJsonData();
            }
            catch (Exception ex)
            {
            }

            return Ok(fitnessRatingData);
        }

        /// <summary>Warns the player.</summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        ///   WarnPlayer this action method is used to warn to the participants in yoyo fitness test <br />
        /// </returns>
        [HttpGet("WarnPlayer", Name = nameof(WarnPlayer))]
        public ActionResult WarnPlayer(string id)
        {
            var allPlayers = _getPlayerService.GetPlayers();

            try
            {
                int editIndex = allPlayers.FindIndex(o => o.id == Convert.ToInt32(id));
                allPlayers[editIndex].warn = true;
                return Ok(allPlayers[editIndex]);
            }
            catch (Exception)
            {
                return NotFound();
            }

        }

        /// <summary>Results the player.</summary>
        /// <param name="id">The identifier.</param>
        /// <param name="result">The result.</param>
        /// <returns>
        ///   ResultPlayer this action method is used to read final result for the participants in yoyo fitness test <br />
        /// </returns>
        [HttpGet("ResultPlayer", Name = nameof(ResultPlayer))]
        public ActionResult ResultPlayer(string id, string result)
        {
            var playerResult = _resultPlayerService.ResultPlayer( Convert.ToInt32(id), result);

            return Ok(playerResult);
        }
    }
}
