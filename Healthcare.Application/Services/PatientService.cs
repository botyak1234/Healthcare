using Healthcare.Domain.DTOs;
using Healthcare.Infrastructure.Repositories;

namespace Healthcare.Application.Services;

public class PatientService : IPatientService
{
    private readonly IPatientRepository _repo;

    public PatientService(IPatientRepository repo)
    {
        _repo = repo;
    }

    public async Task<List<PatientDto>> GetAllPatientsAsync()
    {
        var list = await _repo.GetAllAsync();

        return list.Select(p => new PatientDto
        {
            Id = p.Id,
            FullName = p.FullName,
            BirthDate = p.BirthDate
        }).ToList();
    }

    public async Task<PatientDto?> GetPatientByIdAsync(int id)
    {
        var p = await _repo.GetByIdAsync(id);
        if (p == null) return null;

        return new PatientDto
        {
            Id = p.Id,
            FullName = p.FullName,
            BirthDate = p.BirthDate
        };
    }
}
