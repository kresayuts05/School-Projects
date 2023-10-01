using HireProgrammer.Core.Contracts;
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
    public class ProgrammerService : IProgrammerService
    {
        readonly IRepository repo;
        private readonly ILanguageService languageService;

        public ProgrammerService(IRepository _repo, ILanguageService _languageService)
        {
            repo = _repo;
            languageService = _languageService;
        }

        public async Task Create(RegisterProgrammerViewModel model, string userId)
        {
            var languages = await languageService.LanguagesById(model.LanguageIds);

            var programmer = new Programmer()
            {
                UserId = userId,
                Experience = model.Experience,
                ShortDescription = model.ShortDescription,
                Languages = (ICollection<Infrastructure.Data.Entities.Language>)languages.ToList()
            };

            await repo.AddAsync(programmer);
            await repo.SaveChangesAsync();
        }
    }
}
