using System.Text.Json.Serialization;

namespace Healthcare.Domain.Entities;

public class Doctor
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Specialty { get; set; } = string.Empty;

    [JsonIgnore]
    public List<Patient> Patients { get; set; } = new();
}
