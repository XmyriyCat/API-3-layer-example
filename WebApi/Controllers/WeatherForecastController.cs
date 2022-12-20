using System.Runtime.InteropServices;
using BLL;
using BLL.DTO;
using DLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly CatalogService _catalogService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, CatalogService catalogService)
        {
            _logger = logger;
            _catalogService = catalogService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            var books = _catalogService.GetAllBooks();
            return Ok(books);
        }

        [HttpPost]
        public IActionResult CreateBook(CreateBookDto createDto)
        {
            Book book = _catalogService.CreateBook(createDto);
            return Ok(book);
        }
    }
}