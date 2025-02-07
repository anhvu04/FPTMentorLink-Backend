using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Repositories.Entities.Base;

namespace Repositories.Entities;

public class Checkpoint : AuditableEntity
{
    [ForeignKey(nameof(Project))] public Guid ProjectId { get; set; }
    [MaxLength(255)] public required string Name { get; set; }
    [MaxLength(2000)] public string? Description { get; set; }

    public virtual Project Project { get; set; } = null!;
}