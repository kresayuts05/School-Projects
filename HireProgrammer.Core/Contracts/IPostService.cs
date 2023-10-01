using HireProgrammer.Core.Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireProgrammer.Core.Contracts
{
    public interface IPostService
    {
        Task<bool> Exists(int id);

        Task Create(PostFormViewModel model);

        Task<IEnumerable<PostViewModel>> AllPostsByUser(string id);

        Task<PostFormViewModel> PostDetailsById(int id);

        Task Edit(int postId, PostFormViewModel model);
    }
}
