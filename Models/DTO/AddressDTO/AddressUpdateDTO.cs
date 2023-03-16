using MeFitAPI.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace MeFitAPI.Models.DTO.UsersDTO;

public class AddressUpdateDTO
{
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string AddressLine3 { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
}
