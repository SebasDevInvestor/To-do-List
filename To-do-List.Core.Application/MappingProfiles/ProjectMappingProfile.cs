using AutoMapper;
using To_do_List.Core.Application.Features.Projects.Dto;
using To_do_List.Core.Domain.Entities;

namespace To_do_List.Core.Application.MappingProfiles;

public class ProjectMappingProfile : Profile
{
    public ProjectMappingProfile()
    {
        CreateMap<ProjectDto, Project>().ReverseMap();
      
    }
    
}