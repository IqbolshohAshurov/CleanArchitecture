namespace Domain.Common;

public abstract class BaseAuditableEntity: BaseEntity
{
    public DateTimeOffset Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTimeOffset Modified { get; set; }

    public string? ModifiedBy { get; set; }
}