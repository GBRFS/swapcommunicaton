using Microsoft.AspNetCore.Mvc;
using UpBrasil.Authorization.Application;
using UpBrasil.Authorization.Integration;

namespace UpBrasil.Authorization.Api;

[ApiController]
[Route("authorizations/shared")]
public class SharedAuthorizationController : ControllerBase
{
    private readonly AuthorizationService _service;

    public SharedAuthorizationController(AuthorizationService service)
    {
        _service = service;
    }

    [HttpPost]
    public ActionResult<SwapAuthorizationResponse> Authorize(
        [FromBody] SwapAuthorizationRequest request)
    {
        var response = _service.Authorize(request);
        return Ok(response);
    }
}
