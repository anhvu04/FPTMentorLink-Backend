using System.ComponentModel.DataAnnotations.Schema;
using Repositories.Entities.Base;

namespace Repositories.Entities;

public class MentorAvailability : AuditableEntity
{
    [ForeignKey(nameof(Mentor))] public Guid MentorId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public virtual Mentor Mentor { get; set; } = null!;
}