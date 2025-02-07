using System.ComponentModel.DataAnnotations.Schema;
using Repositories.Entities.Base;

namespace Repositories.Entities;

public class StudentGroup : AuditableEntity
{
    [ForeignKey(nameof(Student))] public Guid StudentId { get; set; }
    [ForeignKey(nameof(Group))] public Guid GroupId { get; set; }
    public bool IsLeader { get; set; }

    public virtual Student Student { get; set; } = null!;
    public virtual Group Group { get; set; } = null!;
}