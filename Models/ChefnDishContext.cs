using Microsoft.EntityFrameworkCore;

namespace ChefnDishes.Models{
    public class ChefnDishContext: DbContext{
        public ChefnDishContext(DbContextOptions options): base(options){}
        public DbSet<Chef> Chefs {get;set;}
        public DbSet<Dish> Dishes {get;set;}
    }
}