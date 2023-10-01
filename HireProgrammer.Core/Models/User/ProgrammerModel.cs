using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireProgrammer.Core.Models.User
{
    public class ProgrammerModel
    {
        public UserModel User { get; set; }

        public int ClientId { get; set; }

        public int Experience { get; set; }

        public string ShortDescription { get; set; }

        public List<int> LanguageIds { get; set; }
    }
}
