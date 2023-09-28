using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using static HireProgrammer.Infrastructure.Data.Constants.ModelConstraints.ProgrammerConstants;
using HireProgrammer.Infrastructure.Data.Entities;

namespace HireProgrammmer.Infrastructure.Data.Entities
{
    public class Programmer
    {
        public Programmer()
        {
            this.IsActive = true;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        public User User { get; set; }

        [Required]
        [DefaultValue(0)]
        public int Experience { get; set; }

        [DefaultValue(true)]
        public bool IsActive { get; set; }

        [Required]
        [MaxLength(ShortDescriptionMaxLength)]
        public string ShortDescription { get; set; }

        public ICollection<Language> Languages { get; set; } = new HashSet<Language>();

        public ICollection<Post> Posts { get; set; } = new HashSet<Post>(); //odobren li e 
    }
}
