using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IRepositoryWrapper _repoWrapper;
        private readonly ILoggerManager _logger;
        public WeatherForecastController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var domesticAccounts = _repoWrapper.Pet.FindByCondition(x => x.PetType.Equals("Domestic"));
            var owners = _repoWrapper.Pet.FindAll();
            var res= owners.FirstOrDefault(x=>x.PetType== "Dog");
            return new string[] { "value1", "value2" };
        }
    }
}
