using System.ComponentModel.DataAnnotations;

namespace PublicApi.DTO.v1;

public class Note
{
    public Guid Id { get; set; }
        
    [MaxLength(128)]
    public string Title { get; set; } = default!;
        
    [MaxLength(512)]
    public string Description { get; set; } = default!;
    
}

public class NoteCreate
{
    [MaxLength(128)]
    public string Title { get; set; } = default!;
        
    [MaxLength(512)]
    public string Description { get; set; } = default!;
}
    