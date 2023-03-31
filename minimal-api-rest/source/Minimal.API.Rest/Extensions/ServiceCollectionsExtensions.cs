using Minimal.API.Util.Extensions;
using MySql.Data.MySqlClient;
using static Minimal.API.Rest.Model.ProductContext;

namespace Minimal.API.Rest.Extensions
{
    public static class ServiceCollectionsExtensions
    {
        public static WebApplicationBuilder addPersistence(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<GetConnection>(sp =>
                async () =>
                {
                    string connectionString = sp.GetService<IConfiguration>().GetVariable("ConnectionString");
                    var connection = new MySqlConnection(connectionString);
                    await connection.OpenAsync();
                    return connection;
                });
            return builder;
        
        }
    }
}
