using MeFitAPI.Models.Domain;
using MeFitAPI.Models.DTO.UsersDTO;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace MeFitAPI.Models.DTO.ProfilesDTO;

public class ProfileUpdateDTO
{
    [Required]
    public int Id { get; set; }
    public string Weight { get; set; }
    public string Height { get; set; }
    public string MedicalConditions { get; set; }
    public string Disabilities { get; set; }
    public int AddressId { get; set; }
    public Address? Address { get; set; }
    public string? UserId { get; set; }
    public int GoalId { get; set; }
    public int ProgramId { get; set; }
    public int WorkoutId { get; set; }
}
