using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductApi.DTOs;
using ProductApi.Models;
using ProductApi.Repositories;

namespace ProductApi.Services
{
    public class UserService : IUserService
{
    private readonly IUserRepository _repo;

    public UserService(IUserRepository repo)
    {
        _repo = repo;
    }

    public async Task<User> Register(RegisterDto dto)
    {
        var user = new User
        {
            Username = dto.Username,
            Password = dto.Password
        };

        return await _repo.Register(user);
    }

    public async Task<User> Login(LoginDto dto)
    {
        return await _repo.Login(dto.Username, dto.Password);
    }
}
}