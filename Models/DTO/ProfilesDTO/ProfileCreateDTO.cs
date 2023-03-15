using MeFitAPI.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace MeFitAPI.Models.DTO.ProfilesDTO;

public class ProfileCreateDTO
{
    public string? Weight { get; set; }
    public string? Height { get; set; }
    public string? MedicalConditions { get; set; }
    public string? Disabilities { get; set; }
    [Required]
    public string UserId { get; set; }
    public int AddressId { get; set; }
}
