using Microsoft.EntityFrameworkCore;
using Simadmin.Data.Model;

namespace Simadmin.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    public virtual DbSet<Application>? Applications { get; set; }
}