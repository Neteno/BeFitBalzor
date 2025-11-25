using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BeFitBlazor.Models;

namespace BeFitBlazor.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<BeFitBlazor.Models.ExerciseEntry> ExerciseEntry { get; set; } = default!;
        public DbSet<BeFitBlazor.Models.ExerciseType> ExerciseType { get; set; } = default!;
        public DbSet<BeFitBlazor.Models.TrainingSession> TrainingSession { get; set; } = default!;
    }
}
