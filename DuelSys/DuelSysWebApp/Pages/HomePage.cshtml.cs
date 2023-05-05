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
    public class HomePageModel : PageModel
    {
        private TournamentMediator tournamentMediator = new TournamentMediator();
        private UserMediator userMediator = new UserMediator();
       
        private TournamentManager tournamentManager;
        private UserManager userManager;
       
        public Tournament tournament { get; set; }
        public User user { get; set; }
        public Participating participating { get; set; }
        int tournamentid { get; set; }
        public List<Tournament> tournamentList;
        public List<Participating> participatinglist;
        public HomePageModel()
        {
            tournamentManager = new TournamentManager(tournamentMediator);
            userManager = new UserManager(userMediator);
            tournamentList = new List<Tournament>();
            participatinglist = new List<Participating>();
        }
        public void OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {

                if (HttpContext.Session.Get("email") != null)
                {
                    string s = HttpContext.Session.GetString("email");
                    this.user = userManager.GetUserEmail(s);
                   
                }
                foreach (Tournament t in tournamentManager.GetAll())
                {
                    tournamentList.Add(t);
                }
                //foreach(Participating p in tournament.GetAll())
                //{
                //    participatinglist.Add(p);
                //}
            }
        }

       
    }
    
}
