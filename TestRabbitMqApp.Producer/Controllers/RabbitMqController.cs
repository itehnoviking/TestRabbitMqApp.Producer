using Microsoft.AspNetCore.Mvc;
using TestRabbitMqApp.Producer.RabbitMq;

namespace TestRabbitMqApp.Producer.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RabbitMqController : ControllerBase
{
    private readonly IRabbitMqService _rabbitMqService;

    public RabbitMqController(IRabbitMqService mqService)
    {
        _rabbitMqService = mqService;
    }

    [Route("[action]/{message}")]
    [HttpGet]
    public IActionResult SendMessage(string message)
    {
        _rabbitMqService.SendMessage(message);

        return Ok("Сообщение отправлено");
    }
}