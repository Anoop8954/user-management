using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductApi.Models;

namespace ProductApi.Repositories
{
    public interface IUserRepository
    {
        Task<User> Register(User user);
        Task<User> Login(string username, string password);
    }
}