using AutoMapper;
using MediatR;
using To_do_List.Core.Application.Contracts.Persistence;
using To_do_List.Core.Domain.Entities;

namespace To_do_List.Core.Application.Features.Projects.Commands.CreateProjectCommand;

public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly IProjectRepository _projectRepository;
    
    public CreateProjectCommandHandler(IMapper mapper, IProjectRepository projectRepository)
    {
        _mapper = mapper;
        _projectRepository = projectRepository;
    }
    
    public async Task<Guid> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
    {
        //Validate Incoming Data
        
        //Convert to domain entity obj
        var projectToCreate = _mapper.Map<Project>(request);
        
        //add to database
         var entity =await _projectRepository.CreateAsync(null ); //projectToCreate
         
        //return id 
        return entity.Id;
        
    }
}