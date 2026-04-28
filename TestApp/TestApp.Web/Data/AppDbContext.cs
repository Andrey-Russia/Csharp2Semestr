using Microsoft.EntityFrameworkCore;
using TestApp.Models;

namespace TestApp.Data;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
}