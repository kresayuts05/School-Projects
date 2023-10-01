using HireProgrammer.Core.Models.Language;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static HireProgrammer.Infrastructure.Data.Constants.ModelConstraints.UserConstants;

using static HireProgrammer.Infrastructure.Data.Constants.ModelConstraints.ProgrammerConstants;

namespace HireProgrammer.Core.Models.User
{
    public class RegisterProgrammerViewModel
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(EmailMaxLength, MinimumLength = EmailMinLength)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(AddressMaxLength, MinimumLength = AddressMinLength)]
        public string Address { get; set; }

        [Required]
        [StringLength(CountryMaxLength, MinimumLength = CountryMinLength)]
        public string Country { get; set; }

        [Required]
        [StringLength(CityMaxLength, MinimumLength = CityMinLength)]
        public string City { get; set; }

        [Required]
        [Range(typeof(int), "0", "100")]
        public int Experience { get; set; }

        [Required]
        [StringLength(ShortDescriptionMaxLength, MinimumLength = ShortDescriptionMinLength)]
        public string ShortDescription { get; set; }

        public List<int> LanguageIds { get; set; }
        
        public IEnumerable<LanguageModel>? Languages { get; set; } = null!;
    }
}
