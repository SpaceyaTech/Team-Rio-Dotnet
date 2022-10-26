using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SpaceYaTech.BusinessLayerLogic.Dtos;
using SpaceYaTech.BusinessLayerLogic.Interfaces;
using SpaceYaTech.Data;
using SpaceYaTech.Data.Models;

namespace SpaceYaTech.Infra.Services;

public class UserService : IUserService
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;

    public UserService(DatabaseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task AddUserAsync(UserDto user)
    {
        var newUser = _mapper.Map<User>(user);
        _context.Users.Add(newUser);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
    {
        var users = await _context.Users.ToListAsync();
        return _mapper.Map<IEnumerable<UserDto>>(users);
    }
}