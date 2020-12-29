using System;
using System.Collections.Generic;
using System.Text;
using YoYo_Entities;

namespace YoYo_Repository.IYoyoRepository
{
   public interface IFitnessRatingDataRepository
    {
       List<FitnessRating> GetFitnessRatingJsonData();
    }
}
