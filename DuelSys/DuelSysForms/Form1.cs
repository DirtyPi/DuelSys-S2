
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DuelSysForms
{
    public partial class Form1 : Form
    {
        private TournamentManager tournamentManager;
        private TournamentMediator tournamentMediator = new TournamentMediator();
        public Form1()
        {
            InitializeComponent();
            cbTypeOfSportT.DataSource = Enum.GetValues(typeof(TypeOfSportEnum));
            tournamentManager = new TournamentManager(tournamentMediator);
            PopulateTournamentList();
        }
        private void PopulateTournamentList()
        {
            lbTournamentList.Items.Clear();
            foreach(Tournament t in tournamentManager.GetAll())
            {
                lbTournamentList.Items.Add(t.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void btnAddTournament_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTypeOfSportT.Text == "" && tbDescriptionT.Text == "" && tbLocationT.Text == "" && Convert.ToInt32(nudMinPlayersT.Value).ToString() == "" && Convert.ToInt32(nudMaxPlayersT.Value).ToString() == "" && Convert.ToInt32(dtpStartT.Value).ToString() == "")
                {
                    MessageBox.Show("Please fill all data!");

                }
                else
                {
                    Tournament t = new Tournament(dtpStartT.Text, tbLocationT.Text, tbDescriptionT.Text, Convert.ToInt32(nudMaxPlayersT.Value), Convert.ToInt32(nudMinPlayersT.Value), (TypeOfSportEnum)cbTypeOfSportT.SelectedIndex);
                    tournamentManager.Add(t);
                    MessageBox.Show("Success!");

                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid data");
            }
        }

        private void btnStartTournament_Click(object sender, EventArgs e)
        {

        }
    }
}