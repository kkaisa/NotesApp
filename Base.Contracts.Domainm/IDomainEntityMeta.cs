namespace Contracts.Domain.Base

{
    public interface IDomainEntityMeta
    {
        string CreatedBy { get; set; }
        DateTime CreatedAt { get; set; }
        
        string UpdatedBy { get; set; }
        DateTime UpdatedAt { get; set; }
    }
}