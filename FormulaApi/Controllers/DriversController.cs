using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class DriversController : ControllerBase
{
    private readonly ApiDbContext _context;
    public DriversController(ApiDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Driver>>> GetDrivers()
    {
        var drivers = await _context.Drivers.ToListAsync();
        return Ok(drivers);
    }
}