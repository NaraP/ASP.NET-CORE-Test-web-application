using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using YoYo_Entities;
using YoYo_Repository.IYoyoRepository;

namespace YoYo_Repository.YoyoRepository
{
    public class FitnessRatingDataRepository : IFitnessRatingDataRepository
    {

        /// <summary>Gets the fitness rating json data.</summary>
        /// <returns>
        ///  GetFitnessRatingJsonData this method is used to get the all fitness rating json data from the static json file  <br />
        /// </returns>
        public List<FitnessRating> GetFitnessRatingJsonData()
        {
            List<FitnessRating> fitnessRatingData = new List<FitnessRating>();

            try
            {
                var folderDetails = Path.Combine(Directory.GetCurrentDirectory(), $"Data\\{"json\\fitnessrating_beeptest.json"}");
                var jsonText = System.IO.File.ReadAllText(folderDetails);

                fitnessRatingData = JsonConvert.DeserializeObject<List<FitnessRating>>(jsonText);
            }
            catch (Exception ex)
            {
            }
            return fitnessRatingData;
        }
    }
}
