using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Repository
{
    public interface IUserRepository
    {
        Task<List<AppUser>> GetAllUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
    }
}