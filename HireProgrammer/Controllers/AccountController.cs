using HireProgrammer.Core.Contracts;
using HireProgrammer.Core.Models.Profile;
using HireProgrammer.Core.Models.User;
using HireProgrammmer.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HireProgrammer.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly ILanguageService languageService;
        private readonly IFirmService firmService;
        private readonly IUserService userService;
        private readonly IProgrammerService programmerService;

        public AccountController(
            UserManager<User> _userManager,
            SignInManager<User> _signInManager,
            ILanguageService _languageService,
            IFirmService _firmService,
            IUserService _userService,
            IProgrammerService _programmerService
            )
        {
            userManager = _userManager;
            signInManager = _signInManager;
            languageService = _languageService;
            firmService = _firmService;
            userService = _userService;
            programmerService = _programmerService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> RegisterAsProgrammer()
        {
            var model = new RegisterProgrammerViewModel();
            model.Languages = await languageService.AllLanguages();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> RegisterAsProgrammer(RegisterProgrammerViewModel model)
        {
            if (await userService.UserByEmailExists(model.Email))
            {
                ModelState.AddModelError(nameof(model.Email), "There is already a registration with this email!");
            }

            if (model.LanguageIds.Count == 0)
            {
                model.Languages = await languageService.AllLanguages();

                return View(model);
            }

            if (!ModelState.IsValid)
            {
                model.Languages = await languageService.AllLanguages();

                return View(model);
            }

            var user = new User()
            {
                Email = model.Email,
                Name = model.Name,
                UserName = model.Email,
                PhoneNumber = model.PhoneNumber,
                Address = model.Address,
                City = model.City,
                Country = model.Country
            };

            var result = await userManager.CreateAsync(user, model.Password);

            await userManager.AddToRoleAsync(user, "Programmer");
            await programmerService.Create(model, user.Id);

            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, isPersistent: false);

                return RedirectToAction("Index", "Home");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }

            return View(model);
        }


        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> RegisterAsFirm()
        {
            var model = new RegisterFirmViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> RegisterAsFirm(RegisterFirmViewModel model)
        {
            if (await userService.UserByEmailExists(model.Email))
            {
                ModelState.AddModelError(nameof(model.Email), "There is already a registration with this email!");
            }

            if (!ModelState.IsValid)
            {
                model = new RegisterFirmViewModel();

                return View(model);
            }

            var user = new User()
            {
                Email = model.Email,
                Name = model.Name,
                UserName = model.Email,
                PhoneNumber = model.PhoneNumber,
                Address = model.Address,
                City = model.City,
                Country = model.Country
            };

            var result = await userManager.CreateAsync(user, model.Password);

            await userManager.AddToRoleAsync(user, "Firm");
            await firmService.Create(user.Id);

            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, isPersistent: false);

                return RedirectToAction("Index", "Home");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            var model = new LoginViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await userManager.FindByEmailAsync(model.Email);

            if (user != null)
            {
                if (user.IsActive)
                {

                    var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }

            ModelState.AddModelError("", "Invalid login");

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
