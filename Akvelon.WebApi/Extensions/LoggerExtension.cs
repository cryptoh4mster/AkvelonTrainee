using Microsoft.Extensions.Logging.Configuration;
using Serilog;

namespace Akvelon.WebApi.Extensions
{
    public static class LoggerExtension
    {
        public static void SetupLogger(this ILoggingBuilder loggingBuilder, IConfiguration configuration)
        {
            var logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();

            loggingBuilder.AddSerilog(logger);
        }
    }
}
