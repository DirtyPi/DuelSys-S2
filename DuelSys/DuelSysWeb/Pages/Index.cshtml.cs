
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using ClassLibrary;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace DuelSysWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
       
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            
        }

        public void OnGet()
        {

        }
       
    
}
}