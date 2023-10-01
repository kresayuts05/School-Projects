using HireProgrammer.Core.Contracts;
using HireProgrammer.Core.Models.Profile;
using HireProgrammer.Core.Models.User;
using HireProgrammer.Infrastructure.Data.Common;
using HireProgrammmer.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireProgrammer.Core.Services
{
    public class FirmService : IFirmService
    {
        readonly IRepository repo;

        public FirmService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task Create(string userId)
        {
            var firm = new Firm()
            {
                UserId = userId
            };

            await repo.AddAsync(firm);
            await repo.SaveChangesAsync();

        }
    }
}
