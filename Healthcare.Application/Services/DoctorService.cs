using Healthcare.Domain.DTOs;
using Healthcare.Infrastructure.Repositories;

namespace Healthcare.Application.Services;

public class DoctorService : IDoctorService
{
    private readonly IDoctorRepository _repo;

    public DoctorService(IDoctorRepository repo)
    {
        _repo = repo;
    }

    public async Task<List<DoctorDto>> GetDoctorsBySpecialtyAsync(string specialty)
    {
        var list = await _repo.GetBySpecialtyAsync(specialty);

        return list.Select(d => new DoctorDto
        {
            Id = d.Id,
            FullName = d.FullName,
            Specialty = d.Specialty
        }).ToList();
    }
}
