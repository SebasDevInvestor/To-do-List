namespace To_do_List.Core.Domain.Common;

public abstract class BaseProp
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; }  = string.Empty;
    
    public DateTime? DateCreated { get; set; }
    public DateTime? DateEnd { get; set; }
    public DateTime? DateModified { get; set; }
}