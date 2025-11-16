namespace Healthcare.Domain.DTOs;

public class PatientDto
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
}
