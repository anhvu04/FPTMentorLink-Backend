using System.ComponentModel.DataAnnotations;
using Repositories.Entities.Base;

namespace Repositories.Entities;

public class Student : AuditableEntity
{
    [MaxLength(255)]
    public required string Code { get; set; }
    public int Balance { get; set; }
}