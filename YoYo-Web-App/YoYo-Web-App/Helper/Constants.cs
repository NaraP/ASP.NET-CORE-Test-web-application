using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YoYo_Web_App.Helper
{

    /// <summary>
    ///  Constants this class is used to api urls <br />
    /// </summary>
    public static class Constants
    {
        public static readonly string webApiPlayer = @"{0}/api/player/GetPlayers";

        public static readonly string webApiFitnessRating = @"{0}/api/player/FitnessRating";

        public static readonly string webApiWarn = @"{0}/api/player/WarnPlayer";

        public static readonly string webApiResult = @"{0}/api/player/ResultPlayer";

    }
}
