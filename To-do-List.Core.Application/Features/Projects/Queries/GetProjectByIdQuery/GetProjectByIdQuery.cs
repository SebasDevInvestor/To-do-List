using MediatR;
using To_do_List.Core.Application.Features.Projects.Dto;

namespace To_do_List.Core.Application.Features.Projects.Queries.GetProjectByIdQuery;

public record GetProjectByIdQuery(Guid Id) : IRequest<ProjectDto>;
