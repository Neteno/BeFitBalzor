using BeFitBlazor.Models;
using System.ComponentModel.DataAnnotations;

namespace BeFitBlazor.DTOs
{
    public class TrainingSessionDTO
    {
        public int Id { get; set; }
        public DateOnly Start { get; set; }
        public DateOnly End { get; set; }

        public TrainingSessionDTO() { }
        public TrainingSessionDTO(TrainingSession trainingSession) 
        { 
            Id = trainingSession.Id;
            Start = trainingSession.Start;
            End = trainingSession.End;
        }
    }
}
