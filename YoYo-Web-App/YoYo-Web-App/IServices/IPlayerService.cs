using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoYo_Web_App.Models;
using YoYo_Web_App.ViewModel;

namespace YoYo_Web_App.IServices
{
  public  interface IPlayerService
    {
        Task<List<Player>> GetPlayers();
        Task<Player> WarnPlayer(int playerId);
        Task<PlayerResultViewModel> ResultPlayer(int playerId, string result);
        Task<List<FitnessRating>> GetFitnessRating();
    }
}
