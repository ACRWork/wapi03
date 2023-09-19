using Microsoft.AspNetCore.Mvc;

namespace wapi03.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ColorController : Controller
    {
        private static readonly string[] Colors = new[]
        {
        "Red", "Green", "Blue", "Black", "White"
        };

        private readonly ILogger<ColorController> _logger;

        public ColorController(ILogger<ColorController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetColor")]
        public IEnumerable<string> Get()
        {
            return Colors;
        }
    }
}
