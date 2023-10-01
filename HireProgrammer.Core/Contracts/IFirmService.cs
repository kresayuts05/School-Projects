using HireProgrammer.Core.Models.Profile;
using HireProgrammer.Core.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireProgrammer.Core.Contracts
{
    public interface IFirmService
    {
        Task Create(string userId);
    }
}
