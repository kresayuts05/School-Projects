using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static HireProgrammer.Infrastructure.Data.Constants.ModelConstraints.PostConstants;

namespace HireProgrammer.Core.Models.Post
{
    public class PostFormViewModel
    {
        public int? Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

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

        public string? UserId { get; set; }
    }
}
