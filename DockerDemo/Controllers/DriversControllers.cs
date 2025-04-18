using Microsoft.AspNetCore.Mvc; 
using DockerDemo.Data; 
using Microsoft.EntityFrameworkCore; 
using DockerDemo.Models; 

namespace DockerDemo.Controllers; 

[ApiController]
[Route("[controller]")]
public class DriversController : ControllerBase
{
    private readonly ILogger<DriversController>  _logger; 
    private readonly ApiDbContext _context; 

    public DriversController(ILogger<DriversController> logger, ApiDbContext context) =>  (_logger, _context) = (logger, context); 

    [HttpGet(Name = "GetAllDrivers")]
    public async Task<IActionResult> Get()
    {
        var driver = new Driver(){

            DriverNumber = 2, 
            Name = "Test"
        }; 

        _context.Add(driver); 
        await _context.SaveChangesAsync();
        var allDrivers = await _context.Drivers.ToListAsync(); 
        return Ok(allDrivers); 
    } 
}


