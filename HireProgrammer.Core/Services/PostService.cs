using HireProgrammer.Core.Contracts;
using HireProgrammer.Core.Exceptions;
using HireProgrammer.Core.Models.Post;
using HireProgrammer.Infrastructure.Data.Common;
using HireProgrammmer.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireProgrammer.Core.Services
{
    public class PostService : IPostService
    {
        private readonly IRepository repo;
        private readonly IProgrammerService programmerService;
        private readonly IFirmService firmService;
        private readonly IUserService userService;

        public PostService(
            IRepository _repo,
            IProgrammerService _programmerService,
            IFirmService _firmService,
            IUserService _userService)
        {
            repo = _repo;
            this.programmerService = _programmerService;
            this.firmService = _firmService;
            this.userService = _userService;
        }

        public async Task Create(PostFormViewModel model)
        {
            var user = await repo.GetByIdAsync<User>(model.UserId);

            var post = new Post()
            {
                Title = model.Title,
                PostedOn = DateTime.Now,
                Description = model.Description,
                HiringPosition = model.HiringPosition,
                Benefits = model.Benefits,
                StartingSalary = model.StartingSalary,
                WorkingHours = model.WorkingHours,
                IsActive = true
            };

            await repo.AddAsync(post);
            user.Posts.Add(post);
            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<PostViewModel>> AllPostsByUser(string id)
        {
            var posts = await repo.All<Post>()
                 .Where(p => p.UserId == id && p.IsActive == true && p.User.IsActive == true)
                 .OrderByDescending(p => p.Id)
                 .Select(p => new PostViewModel
                 {
                     Id = p.Id,
                     PostedOn = p.PostedOn.ToString("yyyy-M-d"),
                     Description = p.Description,
                     HiringPosition = p.HiringPosition,
                     WorkingHours = p.WorkingHours,
                     StartingSalary = p.StartingSalary,
                     Title = p.Title,
                     UserId = p.UserId
                 })
                 .ToListAsync();

            return posts;
        }

        public async Task<PostFormViewModel> PostDetailsById(int id)
        {
            var post = await repo.AllReadonly<Post>()
                    .Where(p => p.IsActive)
                    .Where(p => p.Id == id)
                    .Select(p => new PostFormViewModel()
                    {
                        Id = p.Id,
                        Description = p.Description,
                        HiringPosition = p.HiringPosition,
                        Benefits = p.Benefits,
                        WorkingHours = p.WorkingHours,
                        StartingSalary = p.StartingSalary,
                        Title = p.Title,
                        UserId = p.UserId
                    })
                    .FirstOrDefaultAsync();

            if (post == null)
            {
                throw new NullReferenceException(GlobalExceptions.PostDoesNotExistExceptionMessage);
            }

            return post;
        }

        public async Task<bool> Exists(int id)
        {
            return await repo.All<Post>()
                .AnyAsync(p => p.Id == id && p.IsActive == true && p.User.IsActive == true);
        }

        public async Task Edit(int postId, PostFormViewModel model)
        {
            var post = await repo.GetByIdAsync<Post>(postId);

            post.Title = model.Title;
            post.PostedOn = DateTime.Now;
            post.Description = model.Description;
            post.HiringPosition = model.HiringPosition;
            post.WorkingHours = model.WorkingHours;
            post.StartingSalary = model.StartingSalary;

            await repo.SaveChangesAsync();
        }
    }
}
