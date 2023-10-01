using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HireProgrammer.Infrastructure.Data.Constants.ModelConstraints.FirmConstants;
using System.ComponentModel;

namespace HireProgrammmer.Infrastructure.Data.Entities
{
    public class Firm
    {
        public Firm()
        {
            this.IsActive = true;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        public User User { get; set; }

        public ICollection<Post> Posts { get; set; } = new HashSet<Post>();

        [DefaultValue(true)]
        public bool IsActive { get; set; }
    }
}
