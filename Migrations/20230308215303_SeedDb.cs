using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MeFitAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Exercises",
                newName: "Description");

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "AddressLine3", "City", "Country", "PostalCode" },
                values: new object[,]
                {
                    { 1, "Dam 1", "", "", "Amsterdam", "Netherlands", "1012 JS" },
                    { 2, "Grote Markt 1", "", "", "Groningen", "Netherlands", "9711 LV" },
                    { 3, "Oudegracht 129", "", "", "Utrecht", "Netherlands", "3511 AE" },
                    { 4, "Markt 1", "", "", "Breda", "Netherlands", "4811 WG" },
                    { 5, "Keizersgracht 123", "", "", "Amsterdam", "Netherlands", "1015 CJ" },
                    { 6, "Grote Marktstraat 1", "", "", "Den Haag", "Netherlands", "2511 BJ" },
                    { 7, "Hoogstraat 1", "", "", "Rotterdam", "Netherlands", "3011 PG" },
                    { 8, "Binnenwegplein 1", "", "", "Rotterdam", "Netherlands", "3012 KA" },
                    { 9, "Vrijthof 1", "", "", "Maastricht", "Netherlands", "6211 LE" },
                    { 10, "Neude 1", "", "", "Utrecht", "Netherlands", "3512 JE" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "ImageLink", "Name", "TargetMuscleGroup", "VideoLink" },
                values: new object[,]
                {
                    { 1, "A full-body workout that focuses on strengthening your core and improving your balance.", "https://example.com/squats.jpg", "Squats", "Legs", "https://youtube.com/watch?v=123" },
                    { 2, "A high-intensity interval training (HIIT) session that combines cardio and strength training.", "https://example.com/bench-press.jpg", "Bench Press", "Chest", "https://youtube.com/watch?v=456" },
                    { 3, "An upper-body workout that targets your chest, shoulders, and triceps.", "https://example.com/deadlifts.jpg", "Deadlifts", "Back", "https://youtube.com/watch?v=789" },
                    { 4, "A lower-body workout that focuses on toning your legs and glutes.", "https://example.com/pull-ups.jpg", "Pull-Ups", "Back", "https://youtube.com/watch?v=abc" },
                    { 5, "A flexibility and mobility workout that improves your range of motion and prevents injuries.", "https://example.com/push-ups.jpg", "Push-Ups", "Chest", "https://youtube.com/watch?v=def" },
                    { 6, "A cardio workout that gets your heart rate up and burns calories.", "https://example.com/shoulder-press.jpg", "Shoulder Press", "Shoulders", "https://youtube.com/watch?v=ghi" },
                    { 7, "An agility and coordination workout that challenges your reflexes and balance.", "https://example.com/bicep-curls.jpg", "Bicep Curls", "Biceps", "https://youtube.com/watch?v=jkl" },
                    { 8, "A functional training session that simulates real-life movements and improves your overall fitness.", "https://example.com/tricep-extensions.jpg", "Tricep Extensions", "Triceps", "https://youtube.com/watch?v=mno" },
                    { 9, "A plyometric workout that involves explosive movements and enhances your power and speed.", "https://example.com/crunches.jpg", "Crunches", "Abs", "https://youtube.com/watch?v=pqr" },
                    { 10, "A yoga class that promotes relaxation, mindfulness, and body awareness.", "https://example.com/planks.jpg", "Planks", "Abs", "https://youtube.com/watch?v=stu" }
                });

            migrationBuilder.InsertData(
                table: "GoalWorkouts",
                columns: new[] { "Id", "EndDate", "GoalId", "WorkoutId" },
                values: new object[,]
                {
                    { 1, new DateOnly(2023, 12, 31), 1, 1 },
                    { 2, new DateOnly(2023, 12, 31), 1, 2 },
                    { 3, new DateOnly(2023, 12, 31), 2, 4 },
                    { 4, new DateOnly(2023, 12, 31), 2, 3 },
                    { 5, new DateOnly(2023, 12, 31), 3, 5 },
                    { 6, new DateOnly(2023, 12, 31), 3, 6 },
                    { 7, new DateOnly(2023, 12, 31), 4, 7 },
                    { 8, new DateOnly(2023, 12, 31), 4, 8 },
                    { 9, new DateOnly(2023, 12, 31), 5, 9 },
                    { 10, new DateOnly(2023, 12, 31), 5, 10 }
                });

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "EndDate", "IsAchieved", "ProgramId" },
                values: new object[,]
                {
                    { 1, new DateOnly(2023, 12, 31), false, 1 },
                    { 2, new DateOnly(2023, 12, 31), false, 2 },
                    { 3, new DateOnly(2023, 12, 31), false, 3 },
                    { 4, new DateOnly(2023, 12, 31), false, 4 },
                    { 5, new DateOnly(2023, 12, 31), false, 5 },
                    { 6, new DateOnly(2023, 12, 31), false, 6 },
                    { 7, new DateOnly(2023, 12, 31), false, 7 },
                    { 8, new DateOnly(2023, 12, 31), false, 8 },
                    { 9, new DateOnly(2023, 12, 31), false, 9 },
                    { 10, new DateOnly(2023, 12, 31), false, 10 }
                });

            migrationBuilder.InsertData(
                table: "ProgramWorkouts",
                columns: new[] { "Id", "ProgramId", "WorkoutId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 2, 4 },
                    { 5, 2, 5 },
                    { 6, 2, 6 },
                    { 7, 3, 7 },
                    { 8, 3, 8 },
                    { 9, 3, 9 },
                    { 10, 3, 10 }
                });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "Category", "Name" },
                values: new object[,]
                {
                    { 1, "Strength Training", "Beginner's Strength Training" },
                    { 2, "Running", "Intermediate Running Program" },
                    { 3, "HIIT", "Advanced HIIT Program" },
                    { 4, "Yoga", "Beginner's Yoga Program" },
                    { 5, "Bodyweight", "Intermediate Bodyweight Program" },
                    { 6, "Weightlifting", "Advanced Weightlifting Program" },
                    { 7, "Cardio", "Beginner's Cardio Program" },
                    { 8, "Powerlifting", "Intermediate Powerlifting Program" },
                    { 9, "Crossfit", "Advanced Crossfit Program" },
                    { 10, "Stretching", "Beginner's Stretching Program" }
                });

            migrationBuilder.InsertData(
                table: "Sets",
                columns: new[] { "Id", "ExerciseId", "ExerciseRepetitions" },
                values: new object[,]
                {
                    { 1, 1, 10 },
                    { 2, 2, 8 },
                    { 3, 3, 12 },
                    { 4, 4, 15 },
                    { 5, 5, 10 },
                    { 6, 6, 8 },
                    { 7, 7, 12 },
                    { 8, 8, 15 },
                    { 9, 9, 10 },
                    { 10, 10, 8 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "isAdmin", "isContributor" },
                values: new object[,]
                {
                    { 1, "john@example.com", "John", "Doe", "password123", false, false },
                    { 2, "jane@example.com", "Jane", "Doe", "secret456", false, true },
                    { 3, "admin@example.com", "Admin", "User", "adminpass", true, false },
                    { 4, "alice@example.com", "Alice", "Smith", "qwertyuiop", false, true },
                    { 5, "bob@example.com", "Bob", "Johnson", "asdfghjkl", false, false },
                    { 6, "jimmy@example.com", "Jimmy", "Nguyen", "password", false, true },
                    { 7, "sara@example.com", "Sara", "Kim", "pass123", false, false },
                    { 8, "steve@example.com", "Steve", "Lee", "password1", false, true },
                    { 9, "lisa@example.com", "Lisa", "Garcia", "p@ssw0rd", false, false },
                    { 10, "mike@example.com", "Mike", "Brown", "mypassword", false, true }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "Complete", "Name", "SetId", "Type" },
                values: new object[,]
                {
                    { 1, true, "Squat", 1, "Strength" },
                    { 2, false, "Bench Press", 2, "Strength" },
                    { 3, true, "Deadlift", 3, "Strength" },
                    { 4, true, "Push-up", 4, "Calisthenics" },
                    { 5, false, "Pull-up", 5, "Calisthenics" },
                    { 6, true, "Sprint", 6, "Cardio" },
                    { 7, false, "Swimming", 7, "Cardio" },
                    { 8, true, "Yoga", 8, "Flexibility" },
                    { 9, true, "Pilates", 9, "Flexibility" },
                    { 10, false, "Jump Rope", 10, "Cardio" }
                });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "AddressId", "Disabilities", "GoalId", "Height", "MedicalConditions", "ProgramId", "UserId", "Weight", "WorkoutId" },
                values: new object[,]
                {
                    { 1, 1, "None", 1, "170", "None", 1, 1, "70", 1 },
                    { 2, 2, "None", 2, "160", "Asthma", 2, 2, "65", 2 },
                    { 3, 3, "None", 3, "180", "Diabetes", 3, 3, "80", 3 },
                    { 4, 4, "None", 4, "175", "None", 4, 4, "75", 4 },
                    { 5, 5, "None", 5, "155", "Hypertension", 5, 5, "60", 5 },
                    { 6, 6, "Blindness", 6, "165", "None", 6, 6, "70", 6 },
                    { 7, 7, "None", 7, "190", "Arthritis", 7, 7, "85", 7 },
                    { 8, 8, "Deafness", 8, "195", "None", 8, 8, "90", 8 },
                    { 9, 9, "None", 9, "150", "None", 9, 9, "55", 9 },
                    { 10, 10, "None", 10, "180", "Asthma", 10, 10, "80", 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GoalWorkouts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GoalWorkouts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GoalWorkouts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GoalWorkouts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GoalWorkouts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GoalWorkouts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GoalWorkouts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GoalWorkouts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GoalWorkouts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GoalWorkouts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProgramWorkouts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProgramWorkouts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProgramWorkouts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProgramWorkouts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProgramWorkouts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProgramWorkouts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProgramWorkouts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProgramWorkouts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProgramWorkouts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProgramWorkouts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Exercises",
                newName: "MyProperty");
        }
    }
}
