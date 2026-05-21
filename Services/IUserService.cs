using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductApi.DTOs;
using ProductApi.Models;

namespace ProductApi.Services
{
   public interface IUserService
{
    Task<User> Register(RegisterDto dto);
    Task<User> Login(LoginDto dto);
}
}