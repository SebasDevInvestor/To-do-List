using To_do_List.Core.Domain.Common;
using To_do_List.Core.Domain.Enums;

namespace To_do_List.Core.Domain.Entities;

public class Task : BaseProp
{
    public LevelOfPriority TaskPriority { get; set; }
    public Status  TaskStatus { get; set; }
    
    //FK to Project
    public Guid ProjectId { get; set; }
    
    //Navigation Property Project
    public Project? Projects { get; set; }
    
    
}