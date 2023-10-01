using HireProgrammmer.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HireProgrammer.Infrastructure.Data.Entities;

namespace HireProgrammmer.Infrastructure.Data.Entities
{
    public class ProgrammerLanguage
    {
        [Required]
        [ForeignKey(nameof(Programmer))]
        public int ProgrammerId { get; set; }
        public Programmer Programmer { get; set; }

        [Required]
        [ForeignKey(nameof(Language))]
        public int LanguageId { get; set; }     
        public Language Language { get; set; }     
    }
}
