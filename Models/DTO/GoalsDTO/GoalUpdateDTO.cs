using MeFitAPI.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace MeFitAPI.Models.DTO.UsersDTO;

public class GoalUpdateDTO
{
    [Required]
    public int Id { get; set; }
    public DateOnly EndDate { get; set; }
    public bool IsAchieved { get; set; }
    public int ProgramId { get; set; }
}
