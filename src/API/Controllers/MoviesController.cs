using Asp.Versioning;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiVersion("1.0")]
[ApiController]
[Route("api/v{apiVersion:apiVersion}/[controller]")]
public class MoviesController : ControllerBase
{
    private readonly AppDbContext _db;
    
    public MoviesController(AppDbContext db)
    {
        _db = db;
    }
    
    [HttpGet("[action]")]
    public async Task<IActionResult> Test()
    {
        var movies = await _db.Movies.Include(m => m.Director).ToListAsync();
        return Ok(movies);
    }
}