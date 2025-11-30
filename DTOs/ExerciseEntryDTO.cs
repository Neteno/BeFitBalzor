using BeFitBlazor.Models;
using System.ComponentModel.DataAnnotations;

namespace BeFitBlazor.DTOs
{
    public class ExerciseEntryDTO
    {
        public int Id { get; set; }
        public int TrainingSessionId { get; set; }
        public string TrainingSessionName { get; set; }
        public int ExerciseTypeId { get; set; }
        public string ExerciseTypeName { get; set; }
        public int Weight { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public ExerciseEntryDTO() { }
        public ExerciseEntryDTO(ExerciseEntry exerciseEntry)
        {
            Id = exerciseEntry.Id;
            TrainingSessionId = exerciseEntry.TrainingSessionId;
            TrainingSessionName = exerciseEntry.TrainingSession?.Start.ToString() ?? "";
            ExerciseTypeId = exerciseEntry.ExerciseTypeId;
            ExerciseTypeName = exerciseEntry.ExerciseType?.Name ?? "";
            Weight = exerciseEntry.Weight;
            Sets = exerciseEntry.Sets;
            Reps = exerciseEntry.Reps;
        }

    }
}
