using Api.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("hello")]
[Produces("application/json")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        throw new DoraException();
//        return Ok("Hello, World!");
    }
}