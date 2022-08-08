using Hangfire;
using Newtonsoft.Json;

namespace W2JSoftware.Utils.MediatRHangfire
{
    /// <summary>
    /// 
    /// </summary>
    public static class HangfireConfigurationExtensions
    {
        /// <summary>
        /// Uses the mediat r.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        public static void UseMediatR(this IGlobalConfiguration configuration)
        {
            var jsonSettings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            configuration.UseSerializerSettings(jsonSettings);
        }
    }
}
