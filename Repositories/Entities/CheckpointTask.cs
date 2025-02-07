using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Repositories.Entities.Base;

namespace Repositories.Entities;

public class CheckpointTask : AuditableEntity
{
    [ForeignKey(nameof(Checkpoint))] public Guid CheckpointId { get; set; }
    [MaxLength(255)] public required string Name { get; set; }
    [MaxLength(2000)] public string? Description { get; set; }
    public DateTime Deadline { get; set; }
    public CheckpointTaskStatus Status { get; set; }

    public virtual Checkpoint Checkpoint { get; set; } = null!;
}

public enum CheckpointTaskStatus
{
    Pending = 1,
    InProgress = 2,
    Completed = 3
}