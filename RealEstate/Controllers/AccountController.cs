using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Models.Dto;
using RealEstate.Repositories.Abstract;

namespace RealEstate.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserAuthenticationService _authService;
        public AccountController(IUserAuthenticationService authService)
        {
            this._authService = authService;
        }


        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var result = await _authService.LoginAsync(model);
            if (result.StatusCode == 1)
            {
                return RedirectToAction("Display", "Dashboard");
            }
            else
            {
                TempData["msg"] = result.Message;
                return RedirectToAction(nameof(Login));
            }
        }

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registration(RegistrationModel model)
        {
            if (!ModelState.IsValid) 
            { 
                return View(model);
            }
            model.UserRole = "user";
            var result = await this._authService.RegisterAsync(model);
          TempData["msg"] = result.Message;
            return RedirectToAction(nameof(Registration));
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await this._authService.LogoutAsync();
            return RedirectToAction(nameof(Login));
        }
      
        public IActionResult Profile()
        {
            return View();
        }
       
    }

}

