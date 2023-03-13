using MeFitAPI.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace MeFitAPI.Models.DTO.UsersDTO;

public class ExerciseUpdateDTO
{
    [Required]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string TargetMuscleGroup { get; set; }
    public string ImageLink { get; set; }
    public string VideoLink { get; set; }
}
