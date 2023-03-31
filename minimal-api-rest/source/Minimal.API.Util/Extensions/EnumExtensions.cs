using System.Collections.Concurrent;
using System.ComponentModel;
using System.Reflection;

namespace Minimal.API.Util.Extensions
{
    public static class EnumExtensions
    {
        private static readonly 
            ConcurrentDictionary<string, string> DisplayNameCache = new ConcurrentDictionary<string, string>();

        public static string GetDisplayName(this Enum value) 
        {
            var key = $"{value.GetType().FullName}.{value}";

            var displayName = DisplayNameCache.GetOrAdd(key, x => 
            {
                var name = value
                .GetType()
                .GetTypeInfo()
                .GetField(value.ToString())
                .GetCustomAttribute(typeof(DescriptionAttribute), false);

                return name != null ? name.ToString() : value.ToString();
                });

            return displayName;
        }
    }
}
