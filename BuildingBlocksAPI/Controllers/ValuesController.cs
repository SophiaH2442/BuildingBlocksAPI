using System.Collections.Generic;
using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BuildingBlocksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repoWrapper;

        public ValuesController(ILoggerManager logger, IRepositoryWrapper repoWrapper)
        {
            _logger = logger;
            _repoWrapper = repoWrapper;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _logger.LogInfo("Here is info message from our values controller");
            _logger.LogDebug("Here is the debug message from our values controller");
            _logger.LogWarn("Here is the warn message from our values controller");
            _logger.LogError("Here is the error message from our values controller");

            var domesticCustomers = _repoWrapper.Customer.FindByCondition(x => x.CustomerId.Equals(1));
            var orders = _repoWrapper.Order.FindAll();

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
