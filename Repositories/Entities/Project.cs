using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Repositories.Entities.Base;

namespace Repositories.Entities;

public class Project : AuditableEntity
{
    [MaxLength(255)] public required string Code { get; set; }
    [MaxLength(255)] public required string Name { get; set; }
    [MaxLength(2000)] public string? Description { get; set; }
    [MaxLength(255)] public required string Term { get; set; }
    public ProjectStatus Status { get; set; }
    [ForeignKey(nameof(Group))] public Guid GroupId { get; set; }
    [ForeignKey(nameof(Mentor))] public Guid MentorId { get; set; }
    [ForeignKey(nameof(Lecturer))] public Guid LecturerId { get; set; }

    public virtual Group Group { get; set; } = null!;
    public virtual Mentor Mentor { get; set; } = null!;
    public virtual Lecturer Lecturer { get; set; } = null!;
}

public enum ProjectStatus
{
    Pending = 1,
    InProgress = 2,
    Completed = 3
}