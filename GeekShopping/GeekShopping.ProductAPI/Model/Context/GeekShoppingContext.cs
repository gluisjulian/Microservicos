using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class GeekShoppingContext : DbContext
    {
        public GeekShoppingContext(DbContextOptions<GeekShoppingContext> options): base(options)
        {
            
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
