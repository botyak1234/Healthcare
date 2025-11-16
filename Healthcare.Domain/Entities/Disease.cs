using System.Text.Json.Serialization;

namespace Healthcare.Domain.Entities;

public class Disease
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }

    [JsonIgnore] 
    public List<Patient> Patients { get; set; } = new();
}
