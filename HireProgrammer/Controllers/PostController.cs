using HireProgrammer.Core.Contracts;
using HireProgrammer.Core.Models.Post;
using HireProgrammer.Core.Services;
using HireProgrammer.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HireProgrammer.Controllers
{
    [Authorize]
    public class PostController : Controller
    {
        private readonly IPostService postService;

        public PostController(
           IPostService _postService)
        {
            postService = _postService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new PostFormViewModel()
            {
                UserId = this.User.Id()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PostFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await postService.Create(model);

            return RedirectToAction("Mine", "Post");
        }

        public async Task<IActionResult> Mine()
        {
            try
            {
                var userId = User.Id();

                IEnumerable<PostViewModel> myPosts = await postService.AllPostsByUser(userId);

                return View(myPosts);
            }
            catch (Exception ex)
            {
                TempData["message"] = ex.Message;

                return this.RedirectToAction("Index", "Home");
            }
        }


        
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var model = await postService.PostDetailsById(id);

                return View(model);
            }
            catch (Exception ex)
            {
                TempData["message"] = ex.Message;

                return this.RedirectToAction("Mine", "Post");
            }

        }

        [HttpPost]
        public async Task<IActionResult> Edit(PostFormViewModel model)
        {
            if (ModelState.IsValid == false)
            {
                return RedirectToAction("Mine", "Post");
            }

            try
            {
                await postService.Edit((int)model.Id, model);

                return RedirectToAction(nameof(Mine), new { model.Id });
            }
            catch (Exception ex)
            {
                TempData["message"] = ex.Message;

                return this.RedirectToAction("Mine", "Post");
            }
        }
    }
}
