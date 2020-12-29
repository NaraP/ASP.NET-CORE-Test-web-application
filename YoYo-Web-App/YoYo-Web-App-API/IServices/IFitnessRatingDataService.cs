using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoYo_Entities;

namespace YoYo_Web_App_API.IServices
{

    public interface IFitnessRatingDataService
    {
        List<FitnessRating> GetFitnessRatingJsonData();
    }
}
