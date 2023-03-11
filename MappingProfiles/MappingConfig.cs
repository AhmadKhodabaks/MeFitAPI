
using AutoMapper;
using MeFitAPI.Models.Domain;
using MeFitAPI.Models.DTO.ProfilesDTO;

namespace MeFitAPI.MappingProfiles
{
    public class MappingConfig : AutoMapper.Profile
    {
        public MappingConfig()
        {
            CreateMap<ProfileCreateDTO, Models.Domain.Profile>().ReverseMap();
            CreateMap<ProfileUpdateDTO, Models.Domain.Profile>().ReverseMap();
        }
    }
}
