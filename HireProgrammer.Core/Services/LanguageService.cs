using HireProgrammer.Core.Contracts;
using HireProgrammer.Core.Models.Language;
using HireProgrammer.Infrastructure.Data.Common;
using HireProgrammer.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireProgrammer.Core.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly IRepository repo;

        public LanguageService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<IEnumerable<LanguageModel>> AllLanguages()
        {
            return await repo.AllReadonly<Language>()
                 .Select(c => new LanguageModel()
                 {
                     Id = c.Id,
                     Name = c.Name
                 })
                 .ToListAsync();
        }

        public async Task<IEnumerable<Language>> LanguagesById(List<int> ids)
        {
            return await repo.All<Language>()
                .Where(c => ids.Contains(c.Id))
                .ToListAsync();
        }
    }
}
