using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoYo_Web_App.Data;
using YoYo_Web_App.IServices;
using YoYo_Web_App.Services;

namespace YoYo_Web_App
{
    public static class RegisterServices
    {
        #region RegisterConfigServices
        /// <summary>
        /// RegisterChainOfConfigServices
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void RegisterConfigurationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPlayerService, PlayerService>();
        }

        #endregion RegisterConfigServices
    }
}
