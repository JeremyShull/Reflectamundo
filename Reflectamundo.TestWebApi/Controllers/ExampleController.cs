using Microsoft.AspNetCore.Mvc;
using Reflectamundo.TestWebApi.Filters;
using Reflectamundo.TestWebApi.Requests;
using Reflectamundo.TestWebApi.Responses;

namespace Reflectamundo.TestWebApi.Controllers
{
    /// <summary>
    /// An example controller with example endpoints
    /// </summary>
    [ApiController]
    [Route("/api/v1")]
    public class ExampleController : ControllerBase
    {
        private readonly ILogger<ExampleController> _logger;

        /// <summary>
        /// Constructs an instance of a Controller
        /// </summary>
        /// <param name="logger">A logger instance to log with</param>
        public ExampleController(ILogger<ExampleController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// An example of a Get endpoint that will return the filter string
        /// </summary>
        /// <param name="filter">An object used to filter the request</param>
        /// <returns>An <see cref="ExampleResponse"/></returns>
        [HttpGet("example")]
        public IActionResult Get([FromQuery] ExampleFilter filter)
        {
            var response = GetResponse(null, filter);
            return Ok(response);
        }

        /// <summary>
        /// An example of a Post endpoint that will return requets and filter params in a response
        /// </summary>
        /// <param name="request">A request object</param>
        /// <param name="filter">The object used to filter the request</param>
        /// <returns>An <see cref="ExampleResponse"/></returns>
        [HttpPost("example")]
        public IActionResult Post(ExampleRequest request, [FromQuery] ExampleFilter filter)
        {
            var response = GetResponse(request, filter);
            return Ok(response);
        }

        /// <summary>
        /// An example of a Put endpoint that will return requets and filter params in a response
        /// </summary>
        /// <param name="request">A request object</param>
        /// <param name="filter">The object used to filter the request</param>
        /// <returns>An <see cref="ExampleResponse"/></returns>
        [HttpPut("example")]
        public IActionResult Put(ExampleRequest request, [FromQuery] ExampleFilter filter)
        {
            var response = GetResponse(request, filter);
            return Ok(response);
        }

        /// <summary>
        /// An example of a Delete endpoint that will return requets and filter params in a response
        /// </summary>
        /// <param name="request">A request object</param>
        /// <param name="filter">The object used to filter the request</param>
        /// <returns>An <see cref="ExampleResponse"/></returns>
        [HttpDelete("example")]
        public IActionResult Delete(ExampleRequest request, [FromQuery] ExampleFilter filter)
        {
            var response = GetResponse(request, filter);
            return Ok(response);
        }

        private ExampleResponse GetResponse(ExampleRequest? request, [FromQuery] ExampleFilter? filter)
        {
            return new ExampleResponse
            {
                ReturnedString = request?.StringToReturn,
                FilterString = filter?.FilterString
            };
        }
    }
}