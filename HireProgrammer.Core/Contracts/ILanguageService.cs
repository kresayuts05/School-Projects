using HireProgrammer.Core.Models.Language;
using HireProgrammer.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireProgrammer.Core.Contracts
{
    public interface ILanguageService
    {
        Task<IEnumerable<LanguageModel>> AllLanguages();

        Task<IEnumerable<Language>> LanguagesById(List<int> ids);
    }
}
