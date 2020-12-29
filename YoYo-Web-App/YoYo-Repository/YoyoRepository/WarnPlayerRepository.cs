using System;
using System.Collections.Generic;
using System.Text;
using YoYo_Entities;
using YoYo_Repository.IYoyoRepository;

namespace YoYo_Repository.YoyoRepository
{
    public class WarnPlayerRepository : IWarnPlayerRepository
    {
        private readonly IGetPlayerRepository _getPlayerRepository;


        /// <summary>Initializes a new instance of the <see cref="WarnPlayerRepository" /> class.</summary>
        /// <param name="getPlayerRepository">The get player repository.</param>
        public WarnPlayerRepository(IGetPlayerRepository getPlayerRepository)
        {
            _getPlayerRepository = getPlayerRepository;
        }

        /// <summary>Warns the player.</summary>
        /// <param name="playerId">The player identifier.</param>
        /// <returns>
        /// WarnPlayer this method is used to warn the yoyo fitness test participents  <br />
        /// </returns>
        public Player WarnPlayer(int playerId)
        {
            var playersList = _getPlayerRepository.GetPlayers();
            int editIndex = playersList.FindIndex(o => o.id == playerId);
            playersList[editIndex].warn = true;
            //save data someware..

            return playersList[editIndex];
        }
    }
}
