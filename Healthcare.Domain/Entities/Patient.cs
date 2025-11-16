using System.Text.Json.Serialization;

namespace Healthcare.Domain.Entities;

public class Patient
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }

    public int DoctorId { get; set; }

    [JsonIgnore]
    public Doctor Doctor { get; set; } = null!;

    [JsonIgnore]
    public List<Disease> Diseases { get; set; } = new();
}
