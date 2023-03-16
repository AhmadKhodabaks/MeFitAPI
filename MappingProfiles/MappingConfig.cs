
using AutoMapper;
using MeFitAPI.Models.Domain;
using MeFitAPI.Models.DTO.ProfilesDTO;
using MeFitAPI.Models.DTO.UsersDTO;

namespace MeFitAPI.MappingProfiles
{
    public class MappingConfig : AutoMapper.Profile
    {
        public MappingConfig()
        {
            // Profiles
            CreateMap<ProfileCreateDTO, Models.Domain.Profile>().ReverseMap();
            CreateMap<ProfileUpdateDTO, Models.Domain.Profile>().ReverseMap();

            // Users
            CreateMap<UserCreateDTO, User>().ReverseMap();
            CreateMap<UserUpdateDTO, User>().ReverseMap();

            // Workouts
            CreateMap<WorkoutCreateDTO, Workout>().ReverseMap();
            CreateMap<WorkoutUpdateDTO, Workout>().ReverseMap();

            // Goals
            CreateMap<GoalCreateDTO, Goal>().ReverseMap();
            CreateMap<GoalUpdateDTO, Goal>().ReverseMap();

            // Exercises
            CreateMap<ExerciseCreateDTO, Exercise>().ReverseMap();
            CreateMap<ExerciseUpdateDTO, Exercise>().ReverseMap();

            // Addresses
            CreateMap<AddressCreateDTO, Address>().ReverseMap();
            CreateMap<AddressUpdateDTO, Address>().ReverseMap();
        }
    }
}
