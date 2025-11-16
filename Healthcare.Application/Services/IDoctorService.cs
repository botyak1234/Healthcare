using Healthcare.Domain.DTOs;

namespace Healthcare.Application.Services;

public interface IDoctorService
{
    Task<List<DoctorDto>> GetDoctorsBySpecialtyAsync(string specialty);
}
