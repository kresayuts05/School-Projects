using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireProgrammer.Infrastructure.Data.Entities
{
    public class Language
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [DefaultValue(false)]
        public bool IsFunctionalLanguage { get; set; }
    }
}
