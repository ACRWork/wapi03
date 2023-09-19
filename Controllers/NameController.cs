using Microsoft.AspNetCore.Mvc;

namespace wapi03.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : Controller
    {
        private static readonly string[] Names = new[]
       {
        "Red", "Green", "Blue", "Black", "White"
        };

        private readonly ILogger<NameController> _logger;

        public NameController(ILogger<NameController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetName")]
        public IEnumerable<string> Get()
        {
            return Names;
        }
    }
}
