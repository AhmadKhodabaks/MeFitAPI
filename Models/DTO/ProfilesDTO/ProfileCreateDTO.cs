using MeFitAPI.Models.Domain;
using MeFitAPI.Models.DTO.UsersDTO;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MeFitAPI.Models.DTO.ProfilesDTO;

public class ProfileCreateDTO
{
    public int Id { get; set; }
    public string? Weight { get; set; }
    public string? Height { get; set; }
    public string? MedicalConditions { get; set; }
    public string? Disabilities { get; set; }
    [Required]
    public string UserId { get; set; }
    public AddressCreateDTO Address { get; set; }
}
