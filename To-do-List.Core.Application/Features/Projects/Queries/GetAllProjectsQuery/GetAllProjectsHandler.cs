using AutoMapper;
using MediatR;
using To_do_List.Core.Application.Contracts.Persistence;
using To_do_List.Core.Application.Features.Projects.Dto;


namespace To_do_List.Core.Application.Features.Projects.Queries.GetAllProjectsQuery;

public class GetAllProjectsHandler : IRequestHandler<GetAllProjectsQuery,List<ProjectDto>>
{
    private readonly IMapper  _mapper;
    private readonly IProjectRepository  _projectRepository;
    
    public GetAllProjectsHandler(IMapper mapper, IProjectRepository  projectRepository)
    {
        this._mapper = mapper;
        this._projectRepository = projectRepository;
        
    }
    
    public async Task<List<ProjectDto>> Handle(GetAllProjectsQuery request, CancellationToken cancellationToken)
    {
        //query database 
        var projects = await _projectRepository.GetAllAsync();
        
        //convert data obj to DTO obj
        var data = _mapper.Map<List<ProjectDto>>(projects);

        //Return 
        return data;
    }
}