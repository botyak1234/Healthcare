using Healthcare.Domain.Entities;

namespace Healthcare.Infrastructure.Repositories;

public interface IDoctorRepository
{
    Task<List<Doctor>> GetBySpecialtyAsync(string specialty);
}
