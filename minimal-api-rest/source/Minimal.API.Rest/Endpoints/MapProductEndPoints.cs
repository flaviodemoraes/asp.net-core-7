using Dapper.Contrib.Extensions;
using Microsoft.AspNetCore.Authorization;
using Minimal.API.Rest.Model;
using static Minimal.API.Rest.Model.ProductContext;

namespace Minimal.API.Rest.Endpoints
{
    public static class ProductEndPoints
    {
        public static void MapProductEndPoints(this WebApplication app)
        {
            app.MapGet("/", () => "Product API");

            app.MapGet("/products", async (GetConnection connectionGetter) =>
            {
                using var conn = await connectionGetter();
                return await conn.GetAllAsync<Product>();
            });

            app.MapGet("/products/{id}", [Authorize] async (GetConnection connectionGetter, long id) =>
            {
                using var conn = await connectionGetter();
                return await conn.GetAsync<Product>(id);
            });
        }
    }
}
