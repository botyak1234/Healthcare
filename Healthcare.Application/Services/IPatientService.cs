using Healthcare.Domain.DTOs;

namespace Healthcare.Application.Services;

public interface IPatientService
{
    Task<List<PatientDto>> GetAllPatientsAsync();
    Task<PatientDto?> GetPatientByIdAsync(int id);
}
