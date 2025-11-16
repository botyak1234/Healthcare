using Healthcare.Infrastructure.Repositories;
using Healthcare.Domain.Entities;
using Healthcare.Domain.DTOs;

namespace Healthcare.Application.Services;

public class DiseaseService : IDiseaseService
{
    private readonly IDiseaseRepository _repo;

    public DiseaseService(IDiseaseRepository repo)
    {
        _repo = repo;
    }

    public async Task<List<DiseaseDto>> GetAllAsync()
    {
        var list = await _repo.GetAllAsync();
        return list.Select(d => new DiseaseDto
        {
            Id = d.Id,
            Name = d.Name,
            Description = d.Description
        }).ToList();
    }

    public async Task<DiseaseDto?> GetByIdAsync(int id)
    {
        var d = await _repo.GetByIdAsync(id);
        if (d == null) return null;

        return new DiseaseDto
        {
            Id = d.Id,
            Name = d.Name,
            Description = d.Description
        };
    }

    public async Task<bool> UpdateAsync(int id, DiseaseDto update)
    {
        var disease = await _repo.GetByIdAsync(id);
        if (disease is null) return false;

        disease.Name = update.Name;
        disease.Description = update.Description;

        await _repo.UpdateAsync(disease);
        return true;
    }
}
