


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MockTournamentMediator : ITournamentMediator
    {
        List<Tournament> tournaments = new List<Tournament>();
        public void Add(Tournament tournament)
        {

            tournaments.Add(tournament);
        }
        public List<Tournament> GetAll()
        {
            return tournaments;
        }

        public List<int[]> GetMatchWins(List<int> players, int tournamentID)
        {
            throw new NotImplementedException();
        }
    }
}
