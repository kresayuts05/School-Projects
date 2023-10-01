using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static HireProgrammer.Infrastructure.Data.Constants.ModelConstraints.PostConstants;


namespace HireProgrammmer.Infrastructure.Data.Entities
{
    public class Post
    {
        public Post()
        {
            this.IsActive= true;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        public DateTime PostedOn { get; set; }

        [Required]
        [MaxLength(HiringPositionMaxLength)]
        public string HiringPosition { get; set; }

        [Required]
        [MaxLength(BenefitsMaxLength)]
        public string Benefits { get; set; }

        [Required]
        [Range(typeof(int), SalaryMinValue, SalaryMaxValue)]
        public int StartingSalary { get; set; }

        [Required]
        [Range(typeof(int), WorkingHoursMinValue, WorkingHoursMaxValue)]
        public int WorkingHours { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
