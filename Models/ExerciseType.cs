using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BeFitBlazor.Models
{
    public class ExerciseType
    {
        public int Id { get; set; }

        [Display(Name ="Nazwa ćwiczenia")]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
