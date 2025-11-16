using Healthcare.Domain.Entities;


namespace Healthcare.Infrastructure.Repositories;


public interface IPatientRepository
{
Task<List<Patient>> GetAllAsync();
Task<Patient?> GetByIdAsync(int id);
}