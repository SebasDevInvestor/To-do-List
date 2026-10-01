namespace To_do_List.Core.Application.Features.Projects.Dto;

public class ProjectDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; }  = string.Empty;
    public DateTime? DateCreated { get; set; }

}