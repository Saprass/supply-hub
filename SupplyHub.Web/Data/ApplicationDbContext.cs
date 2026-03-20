using Microsoft.EntityFrameworkCore;
using SupplyHub.Web.Models;

namespace SupplyHub.Web.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories => Set<Category>();
}
