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
    public class ProfileModel : PageModel
    {
        private UserManager userManager;
        private UserMediator userMediator = new UserMediator();

        private ParticipatingManager participatingManager;
        private ParticipatingMediator participatingMediator = new ParticipatingMediator();

        private TournamentManager tournamentManager;
        private TournamentMediator tournamentMediator = new TournamentMediator();
        public List<Participating> participatings { get; set; }
        public List<Tournament> tournaments = new List<Tournament>();
        public List<Round> rounds = new List<Round>();
        public List<Match> matches = new List<Match>();
        public User user { get; set; }
        public Participating participating { get; set; }
        public ProfileModel()
        {
            userManager = new UserManager(userMediator);
            participatingManager = new ParticipatingManager(participatingMediator);
            tournamentManager = new TournamentManager(tournamentMediator);
        }
        public void OnGet(int id)
        {
            user = userManager.GetUserID(id);
            if (user.Id != id) { RedirectToPage("index"); }
            participatings = participatingManager.GetAllByPlayerID(id);
            foreach (Participating p in participatings)
            {
                foreach (Tournament t in tournamentManager.GetAll())
                {
                    if (tournamentManager.CompleteTournament(t))
                    {
                        if (p.tournament.id == t.id)
                        {
                            tournaments.Add(t);
                        }
                    }
                }
            }
            foreach (Tournament t2 in tournaments)
            {
                foreach (Match m in t2.GetAll())
                {
                    if (m.Player1.Id == this.user.Id) { matches.Add(m); }
                    else if (m.Player2.Id == this.user.Id) { matches.Add(m); }
                }
            }

        }
    }
}
