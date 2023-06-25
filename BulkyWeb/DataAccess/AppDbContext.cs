using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.DataAccess;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

}
