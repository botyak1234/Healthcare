using Healthcare.Domain.Entities;

namespace Healthcare.Infrastructure.Repositories;

public interface IDiseaseRepository
{
    Task<List<Disease>> GetAllAsync();
    Task<Disease?> GetByIdAsync(int id);
    Task UpdateAsync(Disease disease);
}
