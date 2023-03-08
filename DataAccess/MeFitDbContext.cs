using MeFitAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace MeFitAPI.DataAccess
{
    public class MeFitDbContext : DbContext
    {
        public MeFitDbContext(DbContextOptions<MeFitDbContext> options) : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<Exercise> Exercises { get; set; } = null!;
        public DbSet<Goal> Goals { get; set; } = null!;
        public DbSet<GoalWorkout> GoalWorkouts { get; set; } = null!;
        public DbSet<Profile> Profiles { get; set; } = null!;
        public DbSet<Models.Domain.Program> Programs { get; set; } = null!;
        public DbSet<ProgramWorkout> ProgramWorkouts { get; set; } = null!;
        public DbSet<Set> Sets { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Workout> Workouts { get; set; } = null!;        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().HasData(DbInitializer.SeedAddresses());
            modelBuilder.Entity<Exercise>().HasData(DbInitializer.SeedExercises());
            modelBuilder.Entity<Goal>().HasData(DbInitializer.SeedGoals());
            modelBuilder.Entity<GoalWorkout>().HasData(DbInitializer.SeedGoalWorkouts());
            modelBuilder.Entity<Profile>().HasData(DbInitializer.SeedProfiles());
            modelBuilder.Entity<Models.Domain.Program>().HasData(DbInitializer.SeedPrograms());
            modelBuilder.Entity<ProgramWorkout>().HasData(DbInitializer.SeedProgramWorkouts());
            modelBuilder.Entity<Set>().HasData(DbInitializer.SeedSets());
            modelBuilder.Entity<User>().HasData(DbInitializer.SeedUsers());
            modelBuilder.Entity<Workout>().HasData(DbInitializer.SeedWorkouts());

        }
    }




}
