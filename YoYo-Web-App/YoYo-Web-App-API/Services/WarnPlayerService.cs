using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoYo_Entities;
using YoYo_Repository.IYoyoRepository;
using YoYo_Web_App_API.IServices;

namespace YoYo_Web_App_API.Services
{
    public class WarnPlayerService : IWarnPlayerService
    {
        private readonly IWarnPlayerRepository _warnPlayerRepository;

        /// <summary>Initializes a new instance of the <see cref="WarnPlayerService" /> class.</summary>
        /// <param name="warnPlayerRepository">The warn player repository.</param>
        public WarnPlayerService(IWarnPlayerRepository warnPlayerRepository)
        {
            _warnPlayerRepository = warnPlayerRepository;
        }

        /// <summary>Warns the player.</summary>
        /// <param name="playerId">The player identifier.</param>
        /// <returns>
        /// WarnPlayer this method is used to warn the in the yoyo test participants <br />
        /// </returns>
        public Player WarnPlayer(int playerId)
        {
            return _warnPlayerRepository.WarnPlayer(playerId);
        }
    }
}
