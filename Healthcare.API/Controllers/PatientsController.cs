using Microsoft.AspNetCore.Mvc;
using Healthcare.Application.Services;

namespace Healthcare.Api.Controllers;

[ApiController]
[Route("api/patients")]
public class PatientsController : ControllerBase
{
    private readonly IPatientService _service;

    public PatientsController(IPatientService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
        => Ok(await _service.GetAllPatientsAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var dto = await _service.GetPatientByIdAsync(id);
        return dto is null ? NotFound() : Ok(dto);
    }
}
