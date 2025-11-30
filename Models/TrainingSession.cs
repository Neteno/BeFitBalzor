using System.ComponentModel.DataAnnotations;

namespace BeFitBlazor.Models
{
    public class TrainingSession
    {
        public int Id { get; set; }
        [Display(Name  = "Data i godzina rozpoczęcia")]
        public DateOnly Start {  get; set; }
        [Display(Name = "Data i godzina Zakończenia")]
        public DateOnly End { get; set; }
        public List<ExerciseEntry> ExerciseEntries { get; set; } = new();
    }
}
