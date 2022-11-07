using Logging;
using Microsoft.AspNetCore.Mvc;

namespace Tracing_Logging_Demo.Controllers;

public class PingController : Controller
{
    private readonly ILogger<PingController> _logger;

    public PingController(ILogger<PingController> logger)
    {
        _logger = logger;
    }

    [HttpGet("[action]")]
    public IActionResult Index()
    {
        EventLog.RequestIndex(_logger);
        var i = new Random().Next(0, 5);

        try
        {
            var result = 10 / i;
            EventLog.DivideNumber(_logger, result);
        }
        catch (Exception e)
        {
            EventLog.DivideNumberError(_logger, e);
        }
        return Ok();
    }
}