using SpaceYaTech.BusinessLayerLogic.Dtos;

namespace SpaceYaTech.BusinessLayerLogic.Interfaces;

public interface IUserService
{
    Task AddUserAsync(UserDto user);
    Task<IEnumerable<UserDto>> GetAllUsersAsync();
}