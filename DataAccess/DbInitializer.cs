using MeFitAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace MeFitAPI.DataAccess
{
    public static class DbInitializer
    {
        public static IEnumerable<Address> SeedAddresses()
        {
            return new List<Address>
            {
                    new Address
                    {
                        Id = 1,
                        AddressLine1 = "Dam 1",
                        AddressLine2 = "",
                        AddressLine3 = "",
                        PostalCode = "1012 JS",
                        City = "Amsterdam",
                        Country = "Netherlands"
                    },
                    new Address
                    {
                        Id=2,
                        AddressLine1 = "Grote Markt 1",
                        AddressLine2 = "",
                        AddressLine3 = "",
                        PostalCode = "9711 LV",
                        City = "Groningen",
                        Country = "Netherlands"
                    },
                    new Address
                    {
                        Id = 3,
                        AddressLine1 = "Oudegracht 129",
                        AddressLine2 = "",
                        AddressLine3 = "",
                        PostalCode = "3511 AE",
                        City = "Utrecht",
                        Country = "Netherlands"
                    },
                    new Address
                    {
                        Id = 4,
                        AddressLine1 = "Markt 1",
                        AddressLine2 = "",
                        AddressLine3 = "",
                        PostalCode = "4811 WG",
                        City = "Breda",
                        Country = "Netherlands"
                    },
                    new Address
                    {
                        Id = 5,
                        AddressLine1 = "Keizersgracht 123",
                        AddressLine2 = "",
                        AddressLine3 = "",
                        PostalCode = "1015 CJ",
                        City = "Amsterdam",
                        Country = "Netherlands"
                    },
                    new Address
                    {
                        Id = 6,
                        AddressLine1 = "Grote Marktstraat 1",
                        AddressLine2 = "",
                        AddressLine3 = "",
                        PostalCode = "2511 BJ",
                        City = "Den Haag",
                        Country = "Netherlands"
                    },
                    new Address
                    {
                        Id = 7,
                        AddressLine1 = "Hoogstraat 1",
                        AddressLine2 = "",
                        AddressLine3 = "",
                        PostalCode = "3011 PG",
                        City = "Rotterdam",
                        Country = "Netherlands"
                    },
                    new Address
                    {
                        Id = 8,
                        AddressLine1 = "Binnenwegplein 1",
                        AddressLine2 = "",
                        AddressLine3 = "",
                        PostalCode = "3012 KA",
                        City = "Rotterdam",
                        Country = "Netherlands"
                    },
                    new Address
                    {
                        Id = 9,
                        AddressLine1 = "Vrijthof 1",
                        AddressLine2 = "",
                        AddressLine3 = "",
                        PostalCode = "6211 LE",
                        City = "Maastricht",
                        Country = "Netherlands"
                    },
                    new Address
                    {
                        Id = 10,
                        AddressLine1 = "Neude 1",
                        AddressLine2 = "",
                        AddressLine3 = "",
                        PostalCode = "3512 JE",
                        City = "Utrecht",
                        Country = "Netherlands"
                    }
            };
        }

        public static IEnumerable<Exercise> SeedExercises()
        {
            return new List<Exercise>
           {
               new Exercise { Id = 1, Name = "Squats", Description = "A full-body workout that focuses on strengthening your core and improving your balance.", TargetMuscleGroup = "Legs", ImageLink = "https://example.com/squats.jpg", VideoLink = "https://youtube.com/watch?v=123" },
               new Exercise { Id = 2, Name = "Bench Press", Description = "A high-intensity interval training (HIIT) session that combines cardio and strength training.", TargetMuscleGroup = "Chest", ImageLink = "https://example.com/bench-press.jpg", VideoLink = "https://youtube.com/watch?v=456" },
               new Exercise { Id = 3, Name = "Deadlifts", Description = "An upper-body workout that targets your chest, shoulders, and triceps.", TargetMuscleGroup = "Back", ImageLink = "https://example.com/deadlifts.jpg", VideoLink = "https://youtube.com/watch?v=789" },
               new Exercise { Id = 4, Name = "Pull-Ups", Description = "A lower-body workout that focuses on toning your legs and glutes.", TargetMuscleGroup = "Back", ImageLink = "https://example.com/pull-ups.jpg", VideoLink = "https://youtube.com/watch?v=abc" },
               new Exercise { Id = 5, Name = "Push-Ups", Description = "A flexibility and mobility workout that improves your range of motion and prevents injuries.", TargetMuscleGroup = "Chest", ImageLink = "https://example.com/push-ups.jpg", VideoLink = "https://youtube.com/watch?v=def" },
               new Exercise { Id = 6, Name = "Shoulder Press", Description =  "A cardio workout that gets your heart rate up and burns calories.", TargetMuscleGroup = "Shoulders", ImageLink = "https://example.com/shoulder-press.jpg", VideoLink = "https://youtube.com/watch?v=ghi" },
               new Exercise { Id = 7, Name = "Bicep Curls", Description = "An agility and coordination workout that challenges your reflexes and balance.", TargetMuscleGroup = "Biceps", ImageLink = "https://example.com/bicep-curls.jpg", VideoLink = "https://youtube.com/watch?v=jkl" },
               new Exercise { Id = 8, Name = "Tricep Extensions", Description = "A functional training session that simulates real-life movements and improves your overall fitness.", TargetMuscleGroup = "Triceps", ImageLink = "https://example.com/tricep-extensions.jpg", VideoLink = "https://youtube.com/watch?v=mno" },
               new Exercise { Id = 9, Name = "Crunches", Description = "A plyometric workout that involves explosive movements and enhances your power and speed.", TargetMuscleGroup = "Abs", ImageLink = "https://example.com/crunches.jpg", VideoLink = "https://youtube.com/watch?v=pqr" },
               new Exercise { Id = 10, Name = "Planks", Description = "A yoga class that promotes relaxation, mindfulness, and body awareness.", TargetMuscleGroup = "Abs", ImageLink = "https://example.com/planks.jpg", VideoLink = "https://youtube.com/watch?v=stu" }
           };
        }

        public static IEnumerable<Goal> SeedGoals()
        {
            return new List<Goal>
            {
                    new Goal { Id = 1, EndDate = new DateOnly(2023, 12, 31), IsAchieved = false, ProgramId = 1 },
                    new Goal { Id = 2, EndDate = new DateOnly(2023, 12, 31), IsAchieved = false, ProgramId = 2 },
                    new Goal { Id = 3, EndDate = new DateOnly(2023, 12, 31), IsAchieved = false, ProgramId = 3 },
                    new Goal { Id = 4, EndDate = new DateOnly(2023, 12, 31), IsAchieved = false, ProgramId = 4 },
                    new Goal { Id = 5, EndDate = new DateOnly(2023, 12, 31), IsAchieved = false, ProgramId = 5 },
                    new Goal { Id = 6, EndDate = new DateOnly(2023, 12, 31), IsAchieved = false, ProgramId = 6 },
                    new Goal { Id = 7, EndDate = new DateOnly(2023, 12, 31), IsAchieved = false, ProgramId = 7 },
                    new Goal { Id = 8, EndDate = new DateOnly(2023, 12, 31), IsAchieved = false, ProgramId = 8 },
                    new Goal { Id = 9, EndDate = new DateOnly(2023, 12, 31), IsAchieved = false, ProgramId = 9 },
                    new Goal { Id = 10, EndDate = new DateOnly(2023, 12, 31), IsAchieved = false, ProgramId = 10 }
            };
        }

        public static IEnumerable<GoalWorkout> SeedGoalWorkouts()
        {
            return new List<GoalWorkout>
            {
                new GoalWorkout { Id = 1, EndDate = new DateOnly(2023, 12, 31), WorkoutId = 1, GoalId = 1 },
                new GoalWorkout { Id = 2, EndDate = new DateOnly(2023, 12, 31), WorkoutId = 2, GoalId = 1 },
                new GoalWorkout { Id = 3, EndDate = new DateOnly(2023, 12, 31), WorkoutId = 4, GoalId = 2 },
                new GoalWorkout { Id = 4, EndDate = new DateOnly(2023, 12, 31), WorkoutId = 3, GoalId = 2 },
                new GoalWorkout { Id = 5, EndDate = new DateOnly(2023, 12, 31), WorkoutId = 5, GoalId = 3 },
                new GoalWorkout { Id = 6, EndDate = new DateOnly(2023, 12, 31), WorkoutId = 6, GoalId = 3 },
                new GoalWorkout { Id = 7, EndDate = new DateOnly(2023, 12, 31), WorkoutId = 7, GoalId = 4 },
                new GoalWorkout { Id = 8, EndDate = new DateOnly(2023, 12, 31), WorkoutId = 8, GoalId = 4 },
                new GoalWorkout { Id = 9, EndDate = new DateOnly(2023, 12, 31), WorkoutId = 9, GoalId = 5 },
                new GoalWorkout { Id = 10, EndDate = new DateOnly(2023, 12, 31), WorkoutId = 10, GoalId = 5 }
            };
        }

        public static IEnumerable<Profile> SeedProfiles()
        {
            return new List<Profile>
            {
               new Profile
               {
                        Id = 1,
                        Weight = "70",
                        Height = "170",
                        MedicalConditions = "None",
                        Disabilities = "None",
                        UserId = 1,
                        GoalId = 1,
                        AddressId = 1,
                        ProgramId = 1,
                        WorkoutId = 1
               },
                    new Profile
                    {
                        Id = 2,
                        Weight = "65",
                        Height = "160",
                        MedicalConditions = "Asthma",
                        Disabilities = "None",
                        UserId = 2,
                        GoalId = 2,
                        AddressId = 2,
                        ProgramId = 2,
                        WorkoutId = 2
                    },
                    new Profile
                    {
                        Id = 3,
                        Weight = "80",
                        Height = "180",
                        MedicalConditions = "Diabetes",
                        Disabilities = "None",
                        UserId = 3,
                        GoalId = 3,
                        AddressId = 3,
                        ProgramId = 3,
                        WorkoutId = 3
                    },
                    new Profile
                    {
                        Id = 4,
                        Weight = "75",
                        Height = "175",
                        MedicalConditions = "None",
                        Disabilities = "None",
                        UserId = 4,
                        GoalId = 4,
                        AddressId = 4,
                        ProgramId = 4,
                        WorkoutId = 4
                    },
                    new Profile
                    {
                        Id = 5,
                        Weight = "60",
                        Height = "155",
                        MedicalConditions = "Hypertension",
                        Disabilities = "None",
                        UserId = 5,
                        GoalId = 5,
                        AddressId = 5,
                        ProgramId = 5,
                        WorkoutId = 5
                    },
                    new Profile
                    {
                        Id = 6,
                        Weight = "70",
                        Height = "165",
                        MedicalConditions = "None",
                        Disabilities = "Blindness",
                        UserId = 6,
                        GoalId = 6,
                        AddressId = 6,
                        ProgramId = 6,
                        WorkoutId = 6
                    },
                    new Profile
                    {
                        Id = 7,
                        Weight = "85",
                        Height = "190",
                        MedicalConditions = "Arthritis",
                        Disabilities = "None",
                        UserId = 7,
                        GoalId = 7,
                        AddressId = 7,
                        ProgramId = 7,
                        WorkoutId = 7
                    },
                    new Profile
                    {
                        Id = 8,
                        Weight = "90",
                        Height = "195",
                        MedicalConditions = "None",
                        Disabilities = "Deafness",
                        UserId = 8,
                        GoalId = 8,
                        AddressId = 8,
                        ProgramId = 8,
                        WorkoutId = 8
                    },
                    new Profile
                    {
                        Id = 9,
                        Weight = "55",
                        Height = "150",
                        MedicalConditions = "None",
                        Disabilities = "None",
                        UserId = 9,
                        GoalId = 9,
                        AddressId = 9,
                        ProgramId = 9,
                        WorkoutId = 9
                    },
                    new Profile
                    {
                        Id = 10,
                        Weight = "80",
                        Height = "180",
                        MedicalConditions = "Asthma",
                        Disabilities = "None",
                        UserId = 10,
                        GoalId = 10,
                        AddressId = 10,
                        ProgramId = 10,
                        WorkoutId = 10
                    }
            };
        }

        public static IEnumerable<Models.Domain.Program> SeedPrograms()
        {
            return new List<Models.Domain.Program>()
            {

                new Models.Domain.Program() { Id = 1, Name = "Beginner's Strength Training", Category = "Strength Training" },
                new Models.Domain.Program() { Id = 2, Name = "Intermediate Running Program", Category = "Running" },
                new Models.Domain.Program() { Id = 3, Name = "Advanced HIIT Program", Category = "HIIT" },
                new Models.Domain.Program() { Id = 4, Name = "Beginner's Yoga Program", Category = "Yoga" },
                new Models.Domain.Program() { Id = 5, Name = "Intermediate Bodyweight Program", Category = "Bodyweight" },
                new Models.Domain.Program() { Id = 6, Name = "Advanced Weightlifting Program", Category = "Weightlifting" },
                new Models.Domain.Program() { Id = 7, Name = "Beginner's Cardio Program", Category = "Cardio" },
                new Models.Domain.Program() { Id = 8, Name = "Intermediate Powerlifting Program", Category = "Powerlifting" },
                new Models.Domain.Program() { Id = 9, Name = "Advanced Crossfit Program", Category = "Crossfit" },
                new Models.Domain.Program() { Id = 10, Name = "Beginner's Stretching Program", Category = "Stretching" }
            };
        }

        public static IEnumerable<ProgramWorkout> SeedProgramWorkouts()
        {
            return new List<ProgramWorkout>()
            {

                new ProgramWorkout
                {
                    Id = 1,
                    ProgramId = 1,
                    WorkoutId = 1
                },
                new ProgramWorkout
                {
                    Id = 2,
                    ProgramId = 1,
                    WorkoutId = 2
                },
                new ProgramWorkout
                {
                    Id = 3,
                    ProgramId = 1,
                    WorkoutId = 3
                },
                new ProgramWorkout
                {
                   Id = 4,
                   ProgramId = 2,
                   WorkoutId = 4
                },
                new ProgramWorkout
                {
                    Id = 5,
                    ProgramId = 2,
                    WorkoutId = 5
                },
                new ProgramWorkout
                {
                    Id = 6,
                    ProgramId = 2,
                    WorkoutId = 6
                },
                new ProgramWorkout
                {
                    Id = 7,
                     ProgramId = 3,
                     WorkoutId = 7
                },
                new ProgramWorkout
                {
                    Id = 8,
                    ProgramId = 3,
                    WorkoutId = 8
                },
                new ProgramWorkout
                {
                    Id = 9,
                    ProgramId = 3,
                    WorkoutId = 9
                },
                new ProgramWorkout
                {
                    Id = 10,
                    ProgramId = 3,
                    WorkoutId = 10
                }
            };
        }

        public static IEnumerable<Set> SeedSets()
        {
            return new List<Set>
            {
                new Set { Id = 1, ExerciseRepetitions = 10, ExerciseId = 1 },
                new Set { Id = 2, ExerciseRepetitions = 8, ExerciseId = 2 },
                new Set { Id = 3, ExerciseRepetitions = 12, ExerciseId = 3 },
                new Set { Id = 4, ExerciseRepetitions = 15, ExerciseId = 4 },
                new Set { Id = 5, ExerciseRepetitions = 10, ExerciseId = 5 },
                new Set { Id = 6, ExerciseRepetitions = 8, ExerciseId = 6 },
                new Set { Id = 7, ExerciseRepetitions = 12, ExerciseId = 7 },
                new Set { Id = 8, ExerciseRepetitions = 15, ExerciseId = 8 },
                new Set { Id = 9, ExerciseRepetitions = 10, ExerciseId = 9 },
                new Set { Id = 10, ExerciseRepetitions = 8, ExerciseId = 10 },
            };
        }

        public static IEnumerable<User> SeedUsers()
        {
            return new List<User>
            {
                                new User
                                {
                                    Id = 1,
                                    Email = "john@example.com",
                                    Password = "password123",
                                    FirstName = "John",
                                    LastName = "Doe",
                                    isContributor = false,
                                    isAdmin = false
                                },
                                new User
                                {
                                    Id = 2,
                                    Email = "jane@example.com",
                                    Password = "secret456",
                                    FirstName = "Jane",
                                    LastName = "Doe",
                                    isContributor = true,
                                    isAdmin = false
                                },
                                new User
                                {
                                    Id = 3,
                                    Email = "admin@example.com",
                                    Password = "adminpass",
                                    FirstName = "Admin",
                                    LastName = "User",
                                    isContributor = false,
                                    isAdmin = true
                                },
                                new User
                                {
                                    Id = 4,
                                    Email = "alice@example.com",
                                    Password = "qwertyuiop",
                                    FirstName = "Alice",
                                    LastName = "Smith",
                                    isContributor = true,
                                    isAdmin = false
                                },
                                new User
                                {
                                    Id = 5,
                                    Email = "bob@example.com",
                                    Password = "asdfghjkl",
                                    FirstName = "Bob",
                                    LastName = "Johnson",
                                    isContributor = false,
                                    isAdmin = false
                                },
                                new User
                                {
                                    Id = 6,
                                    Email = "jimmy@example.com",
                                    Password = "password",
                                    FirstName = "Jimmy",
                                    LastName = "Nguyen",
                                    isContributor = true,
                                    isAdmin = false
                                },
                                new User
                                {
                                    Id = 7,
                                    Email = "sara@example.com",
                                    Password = "pass123",
                                    FirstName = "Sara",
                                    LastName = "Kim",
                                    isContributor = false,
                                    isAdmin = false
                                },
                                new User
                                {
                                    Id = 8,
                                    Email = "steve@example.com",
                                    Password = "password1",
                                    FirstName = "Steve",
                                    LastName = "Lee",
                                    isContributor = true,
                                    isAdmin = false
                                },
                                new User
                                {
                                    Id = 9,
                                    Email = "lisa@example.com",
                                    Password = "p@ssw0rd",
                                    FirstName = "Lisa",
                                    LastName = "Garcia",
                                    isContributor = false,
                                    isAdmin = false
                                },
                                new User
                                {
                                    Id = 10,
                                    Email = "mike@example.com",
                                    Password = "mypassword",
                                    FirstName = "Mike",
                                    LastName = "Brown",
                                    isContributor = true,
                                    isAdmin = false
                                }
            };
        }

        public static IEnumerable<Workout> SeedWorkouts()
        {
            return new List<Workout>
            {
                                new Workout
                                {
                                    Id = 1,
                                    Name = "Squat",
                                    Type = "Strength",
                                    Complete = true,
                                    SetId = 1
                                },
                                new Workout
                                {
                                    Id = 2,
                                    Name = "Bench Press",
                                    Type = "Strength",
                                    Complete = false,
                                    SetId = 2
                                },
                                new Workout
                                {
                                    Id = 3,
                                    Name = "Deadlift",
                                    Type = "Strength",
                                    Complete = true,
                                    SetId = 3
                                },
                                new Workout
                                {
                                    Id = 4,
                                    Name = "Push-up",
                                    Type = "Calisthenics",
                                    Complete = true,
                                    SetId = 4
                                },
                                new Workout
                                {
                                    Id = 5,
                                    Name = "Pull-up",
                                    Type = "Calisthenics",
                                    Complete = false,
                                    SetId = 5
                                },
                                new Workout
                                {
                                    Id = 6,
                                    Name = "Sprint",
                                    Type = "Cardio",
                                    Complete = true,
                                    SetId = 6
                                },
                                new Workout
                                {
                                    Id = 7,
                                    Name = "Swimming",
                                    Type = "Cardio",
                                    Complete = false,
                                    SetId = 7
                                },
                                new Workout
                                {
                                    Id = 8,
                                    Name = "Yoga",
                                    Type = "Flexibility",
                                    Complete = true,
                                    SetId = 8
                                },
                                new Workout
                                {
                                    Id = 9,
                                    Name = "Pilates",
                                    Type = "Flexibility",
                                    Complete = true,
                                    SetId = 9
                                },
                                new Workout
                                {
                                    Id = 10,
                                    Name = "Jump Rope",
                                    Type = "Cardio",
                                    Complete = false,
                                    SetId = 10
                                }
            };
        }

    }

}
