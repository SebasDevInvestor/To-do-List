using AutoMapper;
using MediatR;
using To_do_List.Core.Application.Contracts.Persistence;
using To_do_List.Core.Application.Features.Projects.Dto;

namespace To_do_List.Core.Application.Features.Projects.Queries.GetProjectByIdQuery;

public class GetProjectByIdHandler : IRequestHandler<GetProjectByIdQuery,ProjectDto>
{
    
    private readonly IProjectRepository  _projectRepository;
    private readonly IMapper _mapper;

    public GetProjectByIdHandler(IMapper  mapper, IProjectRepository projectRepository)
    {
        this._projectRepository = projectRepository;
        this._mapper = mapper;
    }
    
    
    public async Task<ProjectDto> Handle(GetProjectByIdQuery request, CancellationToken cancellationToken)
    {
        var projectById = await _projectRepository.GetByIdAsync(request.Id);
        
        var dto = _mapper.Map<ProjectDto>(projectById);
        
        return dto;
        
        
    }
}