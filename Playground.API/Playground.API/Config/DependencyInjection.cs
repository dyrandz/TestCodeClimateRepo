using Microsoft.Extensions.DependencyInjection;
using Playground.Data.DataManagers;
using Playground.Data.DataManagers.Interfaces;
using Playground.Service.Services;
using Playground.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playground.API.Config
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterDependencyInjection(this IServiceCollection services)
        {
            //Services
            services.AddTransient<ITestService, TestService>();

            //Data Managers
            services.AddTransient<ITestDataManager, TestDataManager>();

            return services;
        }
    }
}
