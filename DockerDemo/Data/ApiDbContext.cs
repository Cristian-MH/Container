using Microsoft.EntityFrameworkCore; 
using DockerDemo.Models;
namespace DockerDemo.Data; 

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {
        
    }

    public DbSet<Driver> Drivers {get;set;}
}