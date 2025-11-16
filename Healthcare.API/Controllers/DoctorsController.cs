using Microsoft.AspNetCore.Mvc;
using Healthcare.Application.Services;

namespace Healthcare.Api.Controllers;

[ApiController]
[Route("api/doctors")]
public class DoctorsController : ControllerBase
{
    private readonly IDoctorService _service;

    public DoctorsController(IDoctorService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] string specialty)
        => Ok(await _service.GetDoctorsBySpecialtyAsync(specialty));
}
