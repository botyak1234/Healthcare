using Healthcare.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Healthcare.Infrastructure.Repositories;


public class PatientRepository : IPatientRepository
{
    private readonly AppDbContext _db;


    public PatientRepository(AppDbContext db) => _db = db;


    public async Task<List<Patient>> GetAllAsync() =>
        await _db.Patients
        .Include(p => p.Doctor)
        .Include(p => p.Diseases)
        .ToListAsync();


    public async Task<Patient?> GetByIdAsync(int id) =>
        await _db.Patients
        .Include(p => p.Doctor)
        .Include(p => p.Diseases)
        .FirstOrDefaultAsync(p => p.Id == id);
}