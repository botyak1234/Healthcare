using Microsoft.AspNetCore.Mvc;
using Healthcare.Application.Services;
using Healthcare.Domain.DTOs;

namespace Healthcare.Api.Controllers;

[ApiController]
[Route("api/diseases")]
public class DiseasesController : ControllerBase
{
    private readonly IDiseaseService _service;

    public DiseasesController(IDiseaseService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
        => Ok(await _service.GetAllAsync());

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, DiseaseDto update)
    {
        var ok = await _service.UpdateAsync(id, update);
        return ok ? Ok(update) : NotFound();
    }
}
