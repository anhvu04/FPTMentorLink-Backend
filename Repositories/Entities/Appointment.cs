using System.ComponentModel.DataAnnotations.Schema;
using Repositories.Entities.Base;

namespace Repositories.Entities;

public class Appointment : AuditableEntity
{
    [ForeignKey(nameof(Project))] public Guid ProjectId { get; set; }
    public Guid GroupId { get; set; }
    public Guid MentorId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int BaseSalaryPerHour { get; set; }
    public int TotalTime { get; set; }
    public int TotalPayment { get; set; }
    public AppointmentStatus Status { get; set; }

    public virtual Project Project { get; set; } = null!;
}

public enum AppointmentStatus
{
    Pending = 1,
    Accepted = 2,
    Rejected = 3,
    OnGoing = 4,
    Completed = 5,
    Canceled = 6
}