using Microsoft.AspNetCore.Mvc;

namespace DotNetAiSaaS.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AiController : ControllerBase
{
    private readonly ILlmService _llm;

    public AiController(ILlmService llm) => _llm = llm;

    [HttpPost("complete")]
    public async Task<IActionResult> Complete([FromBody] CompleteRequest request)
    {
        var result = await _llm.CompleteAsync(request.Prompt);
        return Ok(new { result });
    }
}

public record CompleteRequest(string Prompt);
