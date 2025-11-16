using Healthcare.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Healthcare.Infrastructure.Repositories;

public class DiseaseRepository : IDiseaseRepository
{
    private readonly AppDbContext _db;

    public DiseaseRepository(AppDbContext db) => _db = db;

    public Task<List<Disease>> GetAllAsync()
        => _db.Diseases.ToListAsync();

    public Task<Disease?> GetByIdAsync(int id)
        => _db.Diseases.FirstOrDefaultAsync(d => d.Id == id);

    public async Task UpdateAsync(Disease disease)
    {
        _db.Diseases.Update(disease);
        await _db.SaveChangesAsync();
    }
}
