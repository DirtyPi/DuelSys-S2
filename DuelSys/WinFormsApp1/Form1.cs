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
    public partial class Form1 : Form
    {
        private TournamentManager tournamentManager;
        private TournamentMediator tournamentMediator = new TournamentMediator();
        private MatchManager matchManager;
        private MatchMediator matchMediator = new MatchMediator();
        private UserMediator userMediator = new UserMediator();
        private UserManager userManager;
        private RoundRobin roundRobin = new RoundRobin();
        public Form1()
        {
            InitializeComponent();
            cbTypeOfSportT.DataSource = Enum.GetValues(typeof(TypeOfSportEnum));
            cbRole.DataSource = Enum.GetValues(typeof(UserRoleEnum));
            tournamentManager = new TournamentManager(tournamentMediator);
            matchManager = new MatchManager(matchMediator);
            userManager = new UserManager(userMediator);
            PopulateTournamentList();
        }
        private void PopulateTournamentList()
        {
            lbTournamentList.Items.Clear();
            foreach (Tournament t in tournamentManager.GetAll())
            {
                lbTournamentList.Items.Add(t.ToString());
            }
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
                    if(nudMinPlayersT.Value > nudMaxPlayersT.Value || dtpStartT.Value > dtpEndTour.Value)
                    {
                        MessageBox.Show("Can not create a tournament witm minimum player count higher than maximum player count");
                    }
                    else
                    {
                        Tournament t = new Tournament(dtpStartT.Text, dtpEndTour.Text, tbLocationT.Text, tbDescriptionT.Text, Convert.ToInt32(nudMaxPlayersT.Value), Convert.ToInt32(nudMinPlayersT.Value), (TypeOfSportEnum)cbTypeOfSportT.SelectedIndex);
                        tournamentManager.Add(t);
                        MessageBox.Show("Success!");
                        PopulateTournamentList();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid data");
            }
        }

       
        private void btnStartTournament_Click(object sender, EventArgs e)
        {
            List<User> players = new List<User>();
            if (lbTournamentList.SelectedIndex >= 0)
            {
                int filtered = Convert.ToInt32(lbTournamentList.SelectedItem.ToString().Substring(0, lbTournamentList.SelectedItem.ToString().IndexOf(" ")));
                Tournament t = tournamentManager.Get(filtered);
                if (t.isTournamentStarted())
                {
                    if (t.GetAll().Count() == 0)//check if matches n round were generatet 
                    {
                        if (t.CheckPlayrsToStart())
                        {
                            MessageBox.Show("Tournament did't reach min capacity of players!");
                        }
                        else
                        {
                            foreach (var item in t.GetAllByTournament())
                            {
                                foreach (var item2 in userManager.GetAll())
                                {
                                    if (item.player.Id == item2.Id)
                                    {
                                        players.Add(item2);
                                        ////MessageBox.Show($"{item2.FullName}");
                                        ////MessageBox.Show($"{item.player.FullName}");
                                    }
                                }
                            }
                            roundRobin.MakeMatchups(players, t);
                            TournamentManagment sm = new TournamentManagment(t);
                            sm.ShowDialog();
                        }
                    }
                    else
                    { TournamentManagment sm = new TournamentManagment(t); sm.ShowDialog(); }
                }
                else {MessageBox.Show("Touranment can not begin till it reaches start date!");}
            }
        }

        //Register user button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbEmail.Text == "" || tbPassword.Text == "" || tbFullName.Text == "" || cbRole.Text == "")
                {
                    MessageBox.Show("Please fill all data fields!");
                }
                else
                {
                    User user = new User(tbEmail.Text,tbPassword.Text,tbFullName.Text,(UserRoleEnum)cbRole.SelectedIndex);
                    userManager.Add(user);
                    MessageBox.Show("Success!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid data!");
            }
        }

        private void btnSortByDate_Click(object sender, EventArgs e)
        {
           

        }
    }
}
