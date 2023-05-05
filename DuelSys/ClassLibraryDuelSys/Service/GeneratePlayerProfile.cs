using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary.Service
{
    public class GeneratePlayerProfile
    {
        private TournamentManager tournamentManager;
        private TournamentMediator tournamentMediator = new TournamentMediator();
        public GeneratePlayerProfile()
        {
            tournamentManager = new TournamentManager(tournamentMediator);
        }
        public void GenerateProfile(List<Participating> participatings, User user)
        {
           
            
        }
    }
}
