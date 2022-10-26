using AutoMapper;
using SpaceYaTech.BusinessLayerLogic.Dtos;
using SpaceYaTech.Data.Models;

namespace SpaceYaTech.Infra.Mapper;

public class AutomapperConfig : Profile
{
    public AutomapperConfig()
    {
        CreateMap<User, UserDto>();
    }
}