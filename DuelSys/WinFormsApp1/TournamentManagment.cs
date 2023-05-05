using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace WinFormsApp1
{
    public partial class TournamentManagment : Form
    {
        private TournamentManager tournamentManager;
        private TournamentMediator tournamentMediator = new TournamentMediator();
        private MatchManager matchManager;
        private MatchMediator matchMediator = new MatchMediator();
        private RoundManager roundManager;
        private RoundMediator roundMediator = new RoundMediator();
        private Tournament tournament;
        public TournamentManagment(Tournament t)
        {
            InitializeComponent();
            tournament = t;
            tournamentManager = new TournamentManager(tournamentMediator);
            matchManager = new MatchManager(matchMediator);
            roundManager = new RoundManager(roundMediator);
            PopulateMatches();
            CompleteMatch();
            CompleteTournament();
        }
        private void PopulateMatches()
        {
            lbMatches.Items.Clear();
            foreach (Match m in tournament.GetAll())
            {
                lbMatches.Items.Add(m.ToString());
            }
        }
        private void CompleteMatch()
        {
            matchManager.CompleteMatch(tournament); 
        }
        private void CompleteTournament()
        {
            if (tournamentManager.CompleteTournament(tournament))
            {
                lbRanking.Items.Clear();
                var p = tournament.GetAllByTournament();
                List<int[]> ranking = new List<int[]>();
                int rank = 1;
                foreach (var item in tournamentManager.GetRanking(tournament))
                {
                    var z = p.FirstOrDefault(pla => pla.player.Id == item[0]);
                    z.Rank = rank;
                    z.Won = item[1];
                    z.Los = item[2];
                    tournament.Update(z);
                    lbRanking.Items.Add(z.ToString());
                    rank++;
                }
            }
        }
        

        private void btnOpenGame_Click(object sender, EventArgs e)
        {
            if (lbMatches.SelectedIndex >= 0)
            {
                if (lbGames.SelectedIndex >= 0)
                {
                    int filtered = Convert.ToInt32(lbGames.SelectedItem.ToString().Substring(0, lbGames.SelectedItem.ToString().IndexOf(" ")));
                    Round r = roundManager.Get(filtered);
                    int filteredM = Convert.ToInt32(lbMatches.SelectedItem.ToString().Substring(0, lbMatches.SelectedItem.ToString().IndexOf(" ")));
                    Match m = matchManager.Get(filteredM);
                    ScoreManager sm = new ScoreManager(r,m,tournament);
                    sm.Show();
                    PopulateMatches();
                    CompleteMatch();
                    CompleteTournament();
                }
                else
                {
                    MessageBox.Show("Match index must be slected!");
                }
            }
            else
            {
                MessageBox.Show("Rpund index must be slected!");
            }
        }

        private void lbMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbGames.Items.Clear();
            if (lbMatches.SelectedIndex >= 0)
            {
                int filtered = Convert.ToInt32(lbMatches.SelectedItem.ToString().Substring(0, lbMatches.SelectedItem.ToString().IndexOf(" ")));
                Match m = matchManager.Get(filtered);
                foreach (Round r in m.GetAllById())
                {
                    lbGames.Items.Add(r.ToString());
                    PopulateMatches();
                    CompleteMatch();
                    CompleteTournament();
                }
            }
        }
    }
}
