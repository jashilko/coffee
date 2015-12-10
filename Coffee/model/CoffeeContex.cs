using System.Data.Entity;
using Coffee.model;
using System.Collections.Generic;

class CoffeeContext : DbContext
{
    public CoffeeContext()
        : base("DefaultConnection")
    { }

    public DbSet<Menu> Menus { get; set; }
    public DbSet<Enum> Enums { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Order> Orders { get; set; }
}