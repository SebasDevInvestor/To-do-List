using To_do_List.Core.Domain.Common;

namespace To_do_List.Core.Domain.Entities;

public class Project : BaseProp
{
    //Navigation Property
    public ICollection<Task> Tasks { get; set; } = new List<Task>();
}