using Microsoft.EntityFrameworkCore;

public class dbContext : DbContext
{
    public dbContext(DbContextOptions<dbContext> options) : base(options)
    {
    }
    public DbSet<TODO> TODOs {get; set;}
}
