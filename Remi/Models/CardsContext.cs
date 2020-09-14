using Microsoft.EntityFrameworkCore;

namespace CardsApi.Models
{
    public class CardsContext : DbContext
    {
        public CardsContext(DbContextOptions<CardsContext> options)
            : base(options)
        {
        }

        public DbSet<Cards.Card> Cards { get; set; }
    }
}