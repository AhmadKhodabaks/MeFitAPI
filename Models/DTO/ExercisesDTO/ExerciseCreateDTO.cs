using MeFitAPI.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace MeFitAPI.Models.DTO.UsersDTO;

public class ExerciseCreateDTO
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public string TargetMuscleGroup { get; set; }
    [Required]
    public string ImageLink { get; set; }
    [Required]
    public string VideoLink { get; set; }
}
