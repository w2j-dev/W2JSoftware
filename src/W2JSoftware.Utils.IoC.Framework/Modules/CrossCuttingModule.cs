using Microsoft.Extensions.DependencyInjection;
using System;
using W2JSoftware.Utils.Common.Interfaces;
using W2JSoftware.Utils.Common.Models;
using W2JSoftware.Utils.Logging;

namespace W2JSoftware.Utils.IoC.Framework.Modules
{
    /// <summary>
    /// 
    /// </summary>
    public static class CrossCuttingModule
    {
        /// <summary>
        /// Registers the cross cutting.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void RegisterCrossCutting(this IServiceCollection services)
        {
            services.AddScoped<ServiceLogger>();
            services.AddScoped<ExceptionLogger>();
            services.AddScoped<IServiceContext, ServiceContext>();

            services.AddScoped<Func<object, LoggerConfig>>(x => (Func<object, LoggerConfig>)(t => new LoggerConfig(t.GetType().Name, x.GetRequiredService<IServiceContext>())));
        }
    }
}
