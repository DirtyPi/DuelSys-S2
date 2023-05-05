using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using ClassLibrary;



namespace DuelSysWeb.Pages
{
    public class LogInModel : PageModel
    {
        
        public UserManager um;
        private UserMediator userMediator = new UserMediator();
        [BindProperty]
       
        public string Email { get; set; }

        [BindProperty]
       
        public string Password { get; set; }
        public LogInModel()
        {
            um = new UserManager(userMediator);

        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(/*string returnUrl*/)
        {
            string returnUrl;
            if (ModelState.IsValid)
            {
                if (um.CheckIfUserCredentials(Email, Password))
                {
                    //um.GetAllUsers();
                    User user = um.GetUserEmail(Email);
                    if (user != null)
                    {

                        List<Claim> claims = new List<Claim>();
                        claims.Add(new Claim(ClaimTypes.Name, Email));
                        if (user.Role == ClassLibrary.UserRoleEnum.EmployeeUser)
                        { claims.Add(new Claim(ClaimTypes.Role, "EmployeeUser")); }
                        else
                        { claims.Add(new Claim(ClaimTypes.Role, "BaseUser")); }
                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));
                        HttpContext.Session.SetString("email", user.Email);
                        if (!String.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
                        {
                            return Redirect(returnUrl);
                        }
                        else
                        {
                            return RedirectToPage("index");
                        }
                    }
                    else
                    {
                        ViewData["Message"] = "User does not have access to the web site!";
                        return Page();
                    }
                }
                else
                {
                    ViewData["Message"] = "Invalid log in wrong email/Something went wrong!";
                    return Page();
                }

            }
            else
            {
                ViewData["Message"] = "The supplied username and / or password is invalid";
               
                return Page();
            }
        }
    }
}
