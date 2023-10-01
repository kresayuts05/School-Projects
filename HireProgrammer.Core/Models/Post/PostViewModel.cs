using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireProgrammer.Core.Models.Post
{
    public class PostViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string PostedOn { get; set; }

        public string HiringPosition { get; set; }

        public int StartingSalary { get; set; }

        public int WorkingHours { get; set; }

        public string UserId { get; set; }
    }
}
