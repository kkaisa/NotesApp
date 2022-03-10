namespace Contracts.Domain.Base
{
    /// <summary>
    /// Default Guid based Domain Entity interface 
    /// </summary>
    public interface IDomainEntityId: IDomainEntityId<Guid>
    {
        
    }
    
    /// <summary>
    /// Universal Domain Entity interface based on generic PK type 
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public interface IDomainEntityId<TKey>
        where TKey: IEquatable<TKey>
    {
        TKey Id { get; set; }
    }
}