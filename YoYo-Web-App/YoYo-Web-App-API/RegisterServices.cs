using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoYo_Logger;
using YoYo_Repository.IYoyoRepository;
using YoYo_Repository.YoyoRepository;
using YoYo_Web_App_API.IServices;
using YoYo_Web_App_API.Services;

namespace YoYo_Web_App_API
{
    public static class RegisterServices
    {
        #region RegisterConfigServices

        /// <summary>
        /// RegisterConfigurationServices this extenction method is used register the all interfcaes with immplimetnation clasess  <br />
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void RegisterConfigurationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IFitnessRatingDataRepository, FitnessRatingDataRepository>();
            services.AddScoped<IGetPlayerRepository, GetPlayerRepository>();
            services.AddScoped<IResultPlayerRepository, ResultPlayerRepository>();
            services.AddScoped<IWarnPlayerRepository, WarnPlayerRepository>();

            services.AddScoped<IFitnessRatingDataService, FitnessRatingDataService>();
            services.AddScoped<IGetPlayerService, GetPlayerService>();
            services.AddScoped<IResultPlayerService, ResultPlayerService>();
            services.AddScoped<IWarnPlayerService, WarnPlayerService>();

            services.AddSingleton<ILoggerManager, LoggerManager>();
        }

        #endregion RegisterConfigServices
    }
}
