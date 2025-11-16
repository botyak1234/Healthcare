using Healthcare.Domain.DTOs;

namespace Healthcare.Application.Services;

public interface IDiseaseService
{
    Task<List<DiseaseDto>> GetAllAsync();
    Task<DiseaseDto?> GetByIdAsync(int id);
    Task<bool> UpdateAsync(int id, DiseaseDto update);
}
