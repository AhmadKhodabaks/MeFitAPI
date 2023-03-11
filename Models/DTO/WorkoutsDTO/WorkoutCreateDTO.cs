﻿using MeFitAPI.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace MeFitAPI.Models.DTO.UsersDTO;

public class WorkoutCreateDTO
{
    public string Name { get; set; }
    public string Type { get; set; }
    public bool Complete { get; set; }
    public int SetId { get; set; }
}
