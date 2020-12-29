using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoYo_Entities;
using YoYo_Repository.IYoyoRepository;
using YoYo_Web_App_API.IServices;

namespace YoYo_Web_App_API.Services
{
    public class ResultPlayerService : IResultPlayerService
    {
        private readonly IResultPlayerRepository _resultPlayerRepository;

        /// <summary>Initializes a new instance of the <see cref="ResultPlayerService" /> class.</summary>
        /// <param name="resultPlayerRepository">The result player repository.</param>
        public ResultPlayerService(IResultPlayerRepository resultPlayerRepository)
        {
            _resultPlayerRepository = resultPlayerRepository;
        }

        /// <summary>Results the player.</summary>
        /// <param name="playerId">The player identifier.</param>
        /// <param name="result">The result.</param>
        /// <returns>
        /// ResultPlayer this method is returns the PlayerResultViewModel model object data <br />
        /// </returns>
        public PlayerResultViewModel ResultPlayer(int playerId, string result)
        {
            return _resultPlayerRepository.ResultPlayer(playerId, result);
        }
    }
}
