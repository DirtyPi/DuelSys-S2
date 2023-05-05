using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySqlX.XDevAPI;
namespace DuelSysWebApp.Pages
{
    [Authorize]
    public class logoutModel : PageModel
    {
        
        public IActionResult OnGet()
        {
            HttpContext.SignOutAsync();
            HttpContext.Session.Remove("email");
            HttpContext.Session.Clear();
            return RedirectToPage("index");

        }

    }
}
