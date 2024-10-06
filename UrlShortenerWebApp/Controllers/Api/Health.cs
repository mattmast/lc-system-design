using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace UrlShortenerWebApp.Controllers.Api;

[Route("api/[controller]")]
[ApiController]
public class Health : ControllerBase
{
    public async Task<JsonResult> Index()
    {
        string data = await Task.Run<string>(() => "ok");
        return new JsonResult(JsonSerializer.Serialize(data));
    }
}
