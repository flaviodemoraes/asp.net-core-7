using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;

namespace Minimal.API.Rest.Model
{
    [Table("Product")]
    public record Product
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public string Barcode { get; set; }
        public decimal CostPrice { get; set; }

    }

    public class ProductContext
    {
        public delegate Task<DbConnection> GetConnection();
    }
}
