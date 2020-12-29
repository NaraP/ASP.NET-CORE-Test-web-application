using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YoYo_Entities;
using YoYo_Repository.IYoyoRepository;

namespace YoYo_Repository.YoyoRepository
{
    public class ResultPlayerRepository : IResultPlayerRepository
    {
        private readonly IGetPlayerRepository _getPlayerRepository;


        /// <summary>Initializes a new instance of the <see cref="ResultPlayerRepository" /> class.</summary>
        /// <param name="getPlayerRepository">The get player repository.</param>
        public ResultPlayerRepository(IGetPlayerRepository getPlayerRepository)
        {
            _getPlayerRepository = getPlayerRepository;
        }


        /// <summary>Results the player.</summary>
        /// <param name="playerId">The player identifier.</param>
        /// <param name="result">The result.</param>
        /// <returns>
        /// ResultPlayer this method is used to get the final result of the participents  <br />
        /// </returns>
        public PlayerResultViewModel ResultPlayer(int playerId, string result)
        {
            var playerResult = new PlayerResultViewModel();

            try
            {
                var playersList =  _getPlayerRepository.GetPlayers();
                int editIndex = playersList.FindIndex(o => o.id == playerId);
                playerResult.id = playersList[editIndex].id;
                playerResult.result = result;
                //save data someware..
            }
            catch (Exception ex)
            {
            }

            return playerResult;
        }
    }
}
