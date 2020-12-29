using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoYo_Entities;
using YoYo_Repository.IYoyoRepository;
using YoYo_Web_App_API.IServices;

namespace YoYo_Web_App_API.Services
{
    /// <summary>
    ///   <br />
    /// </summary>
    public class FitnessRatingDataService : IFitnessRatingDataService
    {
        private readonly IFitnessRatingDataRepository _fitnessRatingDataRepository;

        /// <summary>Initializes a new instance of the <see cref="FitnessRatingDataService" /> class.</summary>
        /// <param name="fitnessRatingDataRepository">The fitness rating data repository.</param>
        public FitnessRatingDataService(IFitnessRatingDataRepository fitnessRatingDataRepository)
        {
            _fitnessRatingDataRepository = fitnessRatingDataRepository;
        }

        /// <summary>Gets the fitness rating json data.</summary>
        /// <returns>
        ///  List<FitnessRating> this returns list of fintnessrating json data <br />
        /// </returns>
        public List<FitnessRating> GetFitnessRatingJsonData()
        {
           return  _fitnessRatingDataRepository.GetFitnessRatingJsonData();
        }
    }
}
