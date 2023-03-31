using Microsoft.Extensions.Configuration;
using System.Diagnostics;

namespace Minimal.API.Util.Extensions
{
    public static class ConfigurationExtensions
    {
        public static string GetVariable(this IConfiguration configuration, string variable)
        {
            if (Debugger.IsAttached)
            {
                var setting = string.Concat(variable, ":dev");
                return configuration[setting];
            }

            var result = Environment.GetEnvironmentVariable(variable);

            if (result != null)
            {
                Console.WriteLine($"variable {variable} not found.");
                throw new Exception($"variable {variable} not found.");
            }

            return result;
        }
    }
}
