using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YoYo_Entities;
using YoYo_Repository.IYoyoRepository;

namespace YoYo_Repository.YoyoRepository
{
    public class GetPlayerRepository : IGetPlayerRepository
    {

        /// <summary>Gets the players.</summary>
        /// <returns>
        ///  GetPlayers this method is used to get the list of yoyo fitness test participents <br />
        /// </returns>
        public List<Player> GetPlayers()
        {
            List<Player> players = new List<Player>();

            var player1 = new Player
            {
                id = 1,
                name = "Ashton Eaton",
                warn = false,
                stop = false,
                levelNumber = 0,
                shuttleNumber = 0
            };

            var player2 = new Player
            {
                id = 2,
                name = "Brayan Clay",
                warn = false,
                stop = false,
                levelNumber = 0,
                shuttleNumber = 0
            };

            var player3 = new Player
            {
                id = 3,
                name = "Dean Karnazes",
                warn = false,
                stop = false,
                levelNumber = 0,
                shuttleNumber = 0
            };

            var player4 = new Player
            {
                id = 4,
                name = "Usain Bolt",
                warn = false,
                stop = false,
                levelNumber = 0,
                shuttleNumber = 0
            };

            var player5 = new Player
            {
                id = 5,
                name = "Anders Blomqvist",
                warn = false,
                stop = false,
                levelNumber = 0,
                shuttleNumber = 0
            };

            var player6 = new Player
            {
                id = 6,
                name = "Narasimha",
                warn = false,
                stop = false,
                levelNumber = 0,
                shuttleNumber = 0
            };

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            players.Add(player4);
            players.Add(player5);
            players.Add(player6);

            return players;
        }
    }
}
