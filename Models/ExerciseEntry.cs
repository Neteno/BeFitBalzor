using System.ComponentModel.DataAnnotations;

namespace BeFitBlazor.Models
{
    public class ExerciseEntry
    {
        public int Id { get; set; }
        [Display(Name  = "Sesja Treningowa")]
        public int TrainingSessionId { get; set; }
        [Display(Name = "Sesja Treningowa")]
        public virtual TrainingSession? TrainingSession { get; set; }
        [Display(Name  = "Typ ćwiczenia")]
        public int ExerciseTypeId { get; set; }
        [Display(Name = "Typ ćwiczenia")]
        public virtual ExerciseType? ExerciseType { get; set; }

        [Display(Name = "Obciążenie (kg)")]
        public double Weight { get; set; }
        [Display(Name = "Serie")]
        public int Sets { get; set; }
        [Display(Name = "Powtórzenia")]
        public int Reps { get; set; }

    }
}
