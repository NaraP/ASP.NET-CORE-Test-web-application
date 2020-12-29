using System;
using System.Collections.Generic;
using System.Text;
using YoYo_Entities;

namespace YoYo_Repository.IYoyoRepository
{
    public interface IWarnPlayerRepository
    {
        Player WarnPlayer(int playerId);
    }
}
