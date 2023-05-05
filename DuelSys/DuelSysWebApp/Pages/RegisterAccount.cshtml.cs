using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClassLibrary;

namespace DuelSysWeb.Pages
{
    public class RegisterAccountModel : PageModel
    {
        [BindProperty]
        public User user { get; set; }
        private UserManager manager;
        private UserMediator mediator = new UserMediator();
        public RegisterAccountModel()
        {
            manager = new UserManager(mediator);
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if (manager.CheckIfUserExists(user) == false)
                {
                    user.Role = UserRoleEnum.BaseUser;
                    manager.Add(user);
                     return new RedirectResult("index");
                }
                else
                {
                    ViewData["Message"] = "Invalid inputed data";
                    return Page();
                }
            }
            else
            {
                ViewData["Message"] = "Please enter all data fields!";
                return Page();
            }
        }
    }
}
