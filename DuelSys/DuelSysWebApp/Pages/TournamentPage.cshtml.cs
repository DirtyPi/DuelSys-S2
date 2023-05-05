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
    public class TournamentPageModel : PageModel
    {
        private TournamentMediator tournamentMediator = new TournamentMediator();
        private UserMediator userMediator = new UserMediator();
        private ParticipatingMediator participatingMediator = new ParticipatingMediator();

        private TournamentManager tournamentManager;
        private UserManager userManager;
        private ParticipatingManager participatingManager;
       [BindProperty]
        public Tournament tournament { get; set; }
       // [BindProperty]
        public User user { get; set; }
       // [BindProperty]
        public Participating participating { get; set; }
        int tournamentid { get; set; }
       public bool isPlayerInTour { get; set; }
        public List<Participating> participatinglist;
        public TournamentPageModel()
        {
            tournamentManager = new TournamentManager(tournamentMediator);
            userManager = new UserManager(userMediator);
            participatingManager = new ParticipatingManager(participatingMediator);
            participatinglist = new List<Participating>();
        }
          public IActionResult OnGet(int id)
          {
           
            tournament = tournamentManager.Get(id);
            tournamentid = id;
           
            participatinglist = tournament.GetAllByTournament();
            if (HttpContext.Session.Get("email") != null)
            {
                string s = HttpContext.Session.GetString("email");
                this.user = userManager.GetUserEmail(s);

            }
            //foreach(Participating p in participatinglist)
            //{
            //    if (p.player.Id == this.user.Id)
            //    {
            //        isPlayerInTour = false;
            //    }
            //    else { isPlayerInTour = true; }
            //}
            participating = tournament.GetByPlayer(this.user.Id);
            if (participating == null) { isPlayerInTour = false; } else { isPlayerInTour = true; }
            return Page();

        }
        public IActionResult OnPost()
        {
            string userC = "";
            if (HttpContext.Session.Get("email") != null)
            {
                userC = HttpContext.Session.GetString("email");
            }
            User u = userManager.GetUserEmail(userC);
            
            tournamentid = Convert.ToInt32(Request.Form["tournament.id"]);
            Tournament t = tournamentManager.Get(tournamentid);
            if (t.isTournamentStarted())
            {
                ViewData["Message"] = "The tournament you are trying to join has stared!";
                return Page();
            }
            else
            {
                if (t.isOpen())
                {
                    if (!t.TournamentAvailability())
                    {
                        ViewData["Message"] = "The tournament you are trying to join has reached it's max capacity of players!";
                        return Page();
                    }
                    else
                    {
                        Participating p = new Participating(t, u, 0, 0, 0);
                        t.Add(p);
                        return RedirectToPage("tournamentpage");
                    }
                }
                else
                {
                    
                    ViewData["Message"] = "Applications for turnament are accepted only a week before it starts";
                    return Page();
                }
               

                  
            }
           
        }
        public IActionResult OnPostDelete()
        {
            string userC = "";
            if (HttpContext.Session.Get("email") != null)
            {
                userC = HttpContext.Session.GetString("email");
            }
            User u = userManager.GetUserEmail(userC);
            Participating p = participatingManager.GetByPlayer(u.Id);
            tournamentid = Convert.ToInt32(Request.Form["tournament.id"]);
            Tournament t = tournamentManager.Get(tournamentid);
            if (t.isTournamentStarted())
            {
                ViewData["Message"] = "The tournament you are trying to join has stared!";
                return Page();
            }
            else
            {
                t.Delete(p);
                return RedirectToPage("tournamentpage");
            }
           
        }
    }
}
