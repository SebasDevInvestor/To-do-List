using MediatR;

namespace To_do_List.Core.Application.Features.Projects.Commands.CreateProjectCommand;

public class CreateProjectCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; }  = string.Empty;
    public DateTime? DateCreated { get; set; }
    
    public ICollection<Task> Tasks { get; set; } = new List<Task>();
    
}