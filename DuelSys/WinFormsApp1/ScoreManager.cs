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
    public partial class ScoreManager : Form
    {
        private Round r;
        private Match m;
        private Tournament t;
        private RoundMediator roundMediator = new RoundMediator();
        private RoundManager roundManager;
        private MatchManager matchManager;
        private MatchMediator matchMediator = new MatchMediator();
        private int matchId;
        public ScoreManager(Round round,Match match,Tournament tournament )
        {
            InitializeComponent();
            r = round;
            m = match;
            t = tournament;
            roundManager = new RoundManager(roundMediator);
            matchManager = new MatchManager(matchMediator);
             (textBox1.Text) = r.ID.ToString();
            matchId = m.ID;
            PopulateListbox();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveScore_Click(object sender, EventArgs e)
        {

            if (tbPlayer1.Text != "" && tbPlayer2.Text != "")
            {
                int resultOfPlayer1 = Convert.ToInt32(tbPlayer1.Text);
                int resultOfPlayer2 = Convert.ToInt32(tbPlayer2.Text);

                int winner = r.FindWinner(resultOfPlayer1, resultOfPlayer2);
                if (winner == 0)
                {
                    MessageBox.Show("Invalid score!");
                }
                else if (winner == 1)
                {
                    Round r = roundManager.Get(Convert.ToInt32(textBox1.Text));
                    if (r.roundStatus == GameStatusEnum.COMPLETE)
                    {
                        MessageBox.Show("This round has already been played!");
                    }
                    else
                    {
                        r.ResultPlayer1 = resultOfPlayer1;
                        r.ResultPlayer2 = resultOfPlayer2;
                        r.roundStatus = GameStatusEnum.COMPLETE;
                        m.UpdateRoundScore(r);
                        this.Close();
                    }
                }
                else if (winner == 2)
                {
                    Round r = roundManager.Get(Convert.ToInt32(textBox1.Text));
                    if (r.roundStatus == GameStatusEnum.COMPLETE)
                    {
                        MessageBox.Show("This round has already been played!");
                    }
                    else
                    {
                        r.ResultPlayer1 = resultOfPlayer1;
                        r.ResultPlayer2 = resultOfPlayer2;
                        r.roundStatus = GameStatusEnum.COMPLETE;
                        m.UpdateRoundScore(r);
                        this.Close();
                    }
                    MessageBox.Show($"{winner}");
                }
                else
                {
                    MessageBox.Show("Please fill the result of the game!");
                }


            }
        }
        private void PopulateListbox()
        {
            Match match = matchManager.Get(matchId);
            lbScore.Items.Add(match.ToString());

        }
    }
}
