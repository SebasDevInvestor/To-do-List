using MediatR;
using To_do_List.Core.Application.Features.Projects.Dto;

namespace To_do_List.Core.Application.Features.Projects.Queries.GetAllProjectsQuery;

public record GetAllProjectsQuery : IRequest<List<ProjectDto>>;
