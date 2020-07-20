using BL.User;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anastasia.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void SetupDI(this IServiceCollection services)
        {
            services.AddScoped<IUserBL, UserBL>();
        }
    }
}
