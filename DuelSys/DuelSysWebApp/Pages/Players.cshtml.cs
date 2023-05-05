using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using ClassLibrary;

namespace DuelSysWebApp.Pages
{
    [Authorize]
    public class PlayersModel : PageModel
    {
        private UserManager userManager;
        private UserMediator userMediator = new UserMediator();
        public User user { get; set; }
        public List<User> users { get; set; }

        public PlayersModel()
        {
            userManager = new UserManager(userMediator);
        }
        public void OnGet()
        {
            users = userManager.GetAll();
            if (HttpContext.Session.Get("email") != null)
            {
                string s = HttpContext.Session.GetString("email");
                this.user = userManager.GetUserEmail(s);
            }
        }
    }
}
