using Microsoft.EntityFrameworkCore;

namespace Pizzeria.Models
{
    public class PizzaKewd
    {
        public int Id { get; set; }
        public string? Nom {  get; set; }
        public string? Description { get; set; }
    }

    class PizzaKewdDB : DbContext
    {
        public PizzaKewdDB(DbContextOptions options) : base(options) { }
        public DbSet<PizzaKewd> Pizzas { get; set; } = null;
    }
}
