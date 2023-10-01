using HireProgrammer.Core.Contracts;
using HireProgrammer.Core.Exceptions;
using HireProgrammer.Core.Models.User;
using HireProgrammer.Infrastructure.Data.Common;
using HireProgrammmer.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireProgrammer.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository repo;

        public UserService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<UserModel> GetUserById(string userId)
        {
            var user = await repo.GetByIdAsync<User>(userId);

            if (user == null || user.IsActive == false)
            {
                throw new NullReferenceException(GlobalExceptions.UserDoesNotExistExceptionMessage);
            }

            var userModel = new UserModel()
            {
                Id = user.Id,
                Address = user.Address,
                City = user.City,
                Country = user.Country,
                Email = user.Email,
                Name = user.Name,
                PhoneNumber = user.PhoneNumber,
            };

            return userModel;
        }

        public async Task<bool> UserByEmailExists(string email)
        {
            var user = await repo.All<User>()
                .FirstOrDefaultAsync(u => u.Email == email && u.IsActive == true);

            return user != null;
        }
    }
}
