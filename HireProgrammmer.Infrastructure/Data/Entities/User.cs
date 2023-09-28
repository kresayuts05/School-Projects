using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HireProgrammer.Infrastructure.Data.Constants.ModelConstraints.UserConstants;


namespace HireProgrammmer.Infrastructure.Data.Entities
{
    public class User : IdentityUser
    {
        public User()
        {
            IsActive = true;
        }

        [Required]
        [MaxLength(AddressMaxLength)]
        public string Address { get; set; }

        [Required]
        [MaxLength(CountryMaxLength)]
        public string Country { get; set; }

        [Required]
        [MaxLength(CityMaxLength)]
        public string City { get; set; }

        public string? ProfilePictureUrl { get; set; }

        public bool IsActive { get; set; }
    }
}
