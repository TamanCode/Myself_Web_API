using Microsoft.AspNetCore.Mvc;

namespace Myself_Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyselfController : ControllerBase
    {
        

        private readonly ILogger<MyselfController> _logger;

        private readonly List<Myself> _info;

        public MyselfController(ILogger<MyselfController> logger)
        {
            _logger = logger;

            _info = new List<Myself>()
            {
                new Myself() { Name = "Taman", Age = 23 , Gender = "Male" },
                new Myself() { Name = "Gunpreet", Age = 17 , Gender = "Female" },
                new Myself() { Name = "Divyansh", Age = 22 , Gender = "Male" }
            };

        }

        //[HttpGet("all")]
        [HttpGet]
        public IEnumerable<Myself> GetAll()
        {
            return _info;
        }


        [HttpGet("{name}")]
        public Myself GetInfoByName(string name)
        {
            return _info.Find(obj => obj.Name == name);
        }

    }
}