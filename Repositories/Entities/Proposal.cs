using System.ComponentModel.DataAnnotations;
using Repositories.Entities.Base;

namespace Repositories.Entities;

public class Proposal : AuditableEntity
{
    [MaxLength(255)] public required string Code { get; set; }
    [MaxLength(255)] public required string Name { get; set; }
    [MaxLength(2000)] public string? Description { get; set; }
    public ProposalStatus Status { get; set; }
}

public enum ProposalStatus
{
    Pending = 1,
    Approved = 2,
    Rejected = 3
}