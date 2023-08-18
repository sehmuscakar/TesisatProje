using BusinessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Tesisat.Extensions;

namespace Tesisat.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    [AllowAnonymous]//bu controllerın erişilmesine izin veriyor arka plan da tüm sistem kilitli durumda
    public class LoginController : Controller
    {
        private readonly ProjeContext _projeContext;

     

        public LoginController( ProjeContext projeContext)
        {
            _projeContext = projeContext;
        }
      // [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Signİn()
        {


            return View();
        }

        [HttpPost]
      //  [AllowAnonymous]
        public async Task<IActionResult> Signİn(User user)
        {

            //bu claims sadece giriş yapmamızı sağlar oturum açmaz oturum için sesssion kullanılması lazım
           var bilgiler = _projeContext.Users.FirstOrDefault(x => x.UserName == user.UserName && x.Password == user.Password);

            if (bilgiler != null)
            {
                //işlemler
                //claims=talepler
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,user.UserName)
                };

                var userİdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userİdentity);

                await HttpContext.SignInAsync(principal);
             // HttpContext.Session.Set<User>("userSession", user);

                return RedirectToAction("Index", "About");
            }

         

            return View();
        


          
        }

        public IActionResult Error404(int code)//program.cs te bu premtreeyi verdik
        {
            return View();
        }




    }
}
