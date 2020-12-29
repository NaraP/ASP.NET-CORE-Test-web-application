using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoYo_Entities;
using YoYo_Repository.IYoyoRepository;
using YoYo_Web_App_API.IServices;

namespace YoYo_Web_App_API.Services
{
    public class GetPlayerService : IGetPlayerService
    {
        private readonly IGetPlayerRepository _getPlayerRepository;

        /// <summary>Initializes a new instance of the <see cref="GetPlayerService" /> class.</summary>
        /// <param name="getPlayerRepository">The get player repository.</param>
        public GetPlayerService(IGetPlayerRepository getPlayerRepository)
        {
            _getPlayerRepository= getPlayerRepository;
        }

        /// <summary>Gets the players.</summary>
        /// <returns>
        /// GetPlayers this method is used to get the list of participants in the yoyo test <br />
        /// </returns>
        public List<Player> GetPlayers()
        {
            return _getPlayerRepository.GetPlayers();
        }
    }
}
