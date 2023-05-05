using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DuelSys
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddTournament_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTypeOfSport.Text == "" && tbDescription.Text == "" && tbLocation.Text == "" && Convert.ToInt32(nUDMaxPlayers.Value).ToString() == "" && Convert.ToInt32(nUDMinPlayers.Value).ToString() == "" && Convert.ToInt32(dtpStartOfTourn.Value).ToString() == "")
                {
                    MessageBox.Show("Please fill all data!");
                }
                else
                {
                     
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid data");
            }
        }
    }
}
