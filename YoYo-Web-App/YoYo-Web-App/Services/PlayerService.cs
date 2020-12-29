using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using YoYo_Web_App.Helper;
using YoYo_Web_App.IServices;
using YoYo_Web_App.Models;
using YoYo_Web_App.ViewModel;

namespace YoYo_Web_App.Services
{
    public class PlayerService : IPlayerService
    {
       static string apiUrl = string.Empty;


        /// <summary>Initializes a new instance of the <see cref="PlayerService" /> class.</summary>
        public PlayerService()
        {
            apiUrl = Environment.GetEnvironmentVariable("apiUrl");
        }


        /// <summary>Gets the fitness rating.</summary>
        /// <returns>
        ///  GetFitnessRating this method is used read fitness rating data from the .net core web api service by using httpclinet <br />
        /// </returns>
        public async Task<List<FitnessRating>> GetFitnessRating()
        {
            List<FitnessRating> fitnessRatings = null;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var url = FillApiAddress(Constants.webApiFitnessRating, apiUrl, string.Empty);

                    fitnessRatings = new List<FitnessRating>();

                    Uri uri = new Uri(url);
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    var response = await client.GetAsync(uri).ConfigureAwait(false);

                    if (response.IsSuccessStatusCode)
                    {
                        fitnessRatings = JsonConvert.DeserializeObject<List<FitnessRating>>(response.Content.ReadAsStringAsync().Result);
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return fitnessRatings;
        }


        /// <summary>Gets the players.</summary>
        /// <returns>
        ///   GetPlayers this method is used to get the list of yoyo fitness test participant from web api service by using httpclinet <br />
        /// </returns>
        public async Task<List<Player>> GetPlayers()
        {
            List<Player> players = null;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var url = FillApiAddress(Constants.webApiPlayer, apiUrl, string.Empty);
                    players = new List<Player>();
                    Uri uri = new Uri(url);
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    var response = await client.GetAsync(uri).ConfigureAwait(false);

                    if (response.IsSuccessStatusCode)
                    {
                        players = JsonConvert.DeserializeObject<List<Player>>(response.Content.ReadAsStringAsync().Result);
                    }
                }
            }
            catch(Exception ex)
            {
            }

            return players;
        }


        /// <summary>Results the player.</summary>
        /// <param name="playerId">The player identifier.</param>
        /// <param name="result">The result.</param>
        /// <returns>
        ///   ResultPlayer this method is used to get the final yoyo fitness test result from web api service by using httpclinet <br />
        ///   <br />
        /// </returns>
        public async Task<PlayerResultViewModel> ResultPlayer(int playerId, string result)
        {
            var playerResult = new PlayerResultViewModel();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var url = FillApiAddress(Constants.webApiResult, apiUrl, string.Empty);

                    UriBuilder builder = new UriBuilder(url);
                    builder.Query = "id=" + playerId + " &result=" + result + "";

                    playerResult = new PlayerResultViewModel();
                    Uri uri = new Uri(url);
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    var response = await client.GetAsync(builder.Uri).ConfigureAwait(false);

                    if (response.IsSuccessStatusCode)
                    {
                        playerResult = JsonConvert.DeserializeObject<PlayerResultViewModel>(response.Content.ReadAsStringAsync().Result);
                    }
                }

                return playerResult;
            }
            catch (Exception ex)
            {
            }

            return playerResult;
        }

        /// <summary>Warns the player.</summary>
        /// <param name="playerId">The player identifier.</param>
        /// <returns>
        ///   WarnPlayer this method is used to get the warn to yoyo fitness test from web api service by using httpclinet <br />
        /// </returns>
        public async Task<Player> WarnPlayer(int playerId)
        {
            Player player = null;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var param = Convert.ToString(playerId);
                    var url = FillApiAddress(Constants.webApiWarn, apiUrl, param);
                    player = new Player();
                    Uri uri = new Uri(url);

                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    var response = await client.GetAsync(uri).ConfigureAwait(false);

                    if (response.IsSuccessStatusCode)
                    {
                        player = JsonConvert.DeserializeObject<Player>(response.Content.ReadAsStringAsync().Result);
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return player;
        }


        /// <summary>Fills the API address.</summary>
        /// <param name="url">The URL.</param>
        /// <param name="_baseUri">The base URI.</param>
        /// <param name="param">The parameter.</param>
        /// <returns>
        ///  FillApiAddress this method is used to fill the .net core web api address <br />
        /// </returns>
        private static string FillApiAddress(string url, string _baseUri,string param)
        {
            if (!string.IsNullOrEmpty(param))
            {
                var Uri = string.Format(url, _baseUri);
                Uri += "?id=" + param.ToString();
                return Uri;
            }
            var Url = string.Format(url, _baseUri);
            return Url;
        }
    }
}
