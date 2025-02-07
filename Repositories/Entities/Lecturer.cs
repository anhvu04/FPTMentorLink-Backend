using System.ComponentModel.DataAnnotations;
using Repositories.Entities.Base;

namespace Repositories.Entities;

public class Lecturer : AuditableEntity
{
    [MaxLength(255)] public required string Code { get; set; }
    [MaxLength(2000)] public string? Description { get; set; }
    [MaxLength(255)] public string? Faculty { get; set; }
}