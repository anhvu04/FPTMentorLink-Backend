using System.ComponentModel.DataAnnotations;
using Repositories.Entities.Base;

namespace Repositories.Entities;

public class Mentor : AuditableEntity
{
    [MaxLength(255)]
    public required string Code { get; set; }
    public int Balance { get; set; }
    [MaxLength(255)]
    public string? BankName { get; set; }
    [MaxLength(255)]
    public string? BankCode { get; set; }
    public int BaseSalaryPerHour { get; set; }
}