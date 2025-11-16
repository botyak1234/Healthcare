using Healthcare.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Healthcare.Infrastructure.Repositories;

public class DoctorRepository : IDoctorRepository
{
    private readonly AppDbContext _db;

    public DoctorRepository(AppDbContext db)
    {
        _db = db;
    }

    public async Task<List<Doctor>> GetBySpecialtyAsync(string specialty)
    {
        return await _db.Doctors
            .Where(d => d.Specialty == specialty)
            .ToListAsync();
    }
}
