using MeFitAPI.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace MeFitAPI.Models.DTO.UsersDTO;

public class UserCreateDTO
{
    public string Email { get; set; }
    public int KeycloakId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool isContributor { get; set; }
    public bool isAdmin { get; set; }
}
