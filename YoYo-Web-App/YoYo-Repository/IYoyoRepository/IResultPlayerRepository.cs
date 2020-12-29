using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YoYo_Entities;

namespace YoYo_Repository.IYoyoRepository
{
    public interface IResultPlayerRepository
    {
        PlayerResultViewModel ResultPlayer(int playerId, string result);
    }
}
