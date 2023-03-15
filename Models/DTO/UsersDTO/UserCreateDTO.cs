using MeFitAPI.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace MeFitAPI.Models.DTO.UsersDTO;

public class UserCreateDTO
{
    public string Email { get; set; }
    public string KeycloakId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool IsContributor { get; set; }
    public bool IsAdmin { get; set; }
}
