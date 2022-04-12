using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentProject;
using TournamentProject.Models;

namespace TrackerUI
{
    /// <summary>
    /// ///////////////  Eagle                          IBird         , IFly
    /// </summary>
    public partial class CreateTournamentForm : Form , IPrizeRequestor , ITeamRequestor
    { 
        List<TeamModel> AvailableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> SelectedTeams = new List<TeamModel>();
        List<PrizeModel> SelectedPrizes = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            SelectTeamDropDown.DataSource = null;
            SelectTeamDropDown.DataSource= AvailableTeams;
            SelectTeamDropDown.DisplayMember = "TeamName";

            TeamsListBox.DataSource = null;
            TeamsListBox.DataSource = SelectedTeams;
            TeamsListBox.DisplayMember = "TeamName";

            PrizesListBox.DataSource= null;
            PrizesListBox.DataSource = SelectedPrizes;
            PrizesListBox.DisplayMember = "PlaceName";


        }

        private void CreateTournamentForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EntryFeeLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)SelectTeamDropDown.SelectedItem;
            if (t != null)
            {
                AvailableTeams.Remove(t);
                SelectedTeams.Add(t);

                WireUpLists();

            }
        }

        private void SelectTeamLabel_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrizesLabel_Click(object sender, EventArgs e)
        {

        }

        private void PrizesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FeeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeletePrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)PrizesListBox.SelectedItem;

            if (p != null)
            {
                SelectedPrizes.Remove(p);
                WireUpLists();
            }
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            // Call the prize form
            CreatePrize PrizeForm = new CreatePrize(this);
            PrizeForm.Show();

        }

        public void PrizeComplete(PrizeModel model)
        {
            // Get back from the form with the prize model
            // Take the prizemodel and put it in its list

            SelectedPrizes.Add(model);
            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            SelectedTeams.Add(model);
            WireUpLists();
        }

        private void CreateNewTeamlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm TeamForm = new CreateTeamForm(this);
            TeamForm.Show();
        }

        private void RemoveTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)TeamsListBox.SelectedItem;

            if (t != null)
            {
                SelectedTeams.Remove(t);
                AvailableTeams.Add(t);
                WireUpLists();
            }
        }

        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            // validate Data 
            decimal fee = 0;
            bool feeAcepptable = decimal.TryParse(FeeTextBox.Text, out fee);
            if (!feeAcepptable)
            {
                MessageBox.Show("Invalid Fee, please enter a valid Fee");
                return;
            }
            // Create the tournament model
            TournamentModel tm = new TournamentModel();
            tm.TournamentName = TournamentNameTextBox.Text;
            tm.EntryFee = fee;
            tm.Prizes = SelectedPrizes;
            tm.EnteredTeams = SelectedTeams;

            // For matchups:
            // Order our list of teams randomly
            // take that list and check if its big enough (2^n) , if not add byes.
            // create ouf first round of matchups
            // create every round after that .. (N/2), N: number of teams in pervious rounds. i.e:(8,4,2,1) matchups
            TournamentProcessor.CreateRounds(tm);

            // Create tournament entries 
            // create all the prizes entries
            // create all the teams entries
            GlobalConfig.Connection.CreateTournament(tm);

            tm.AlertUsersToNewRound();

            TournamentViewer form = new TournamentViewer(tm);
            form.Show();
            this.Close(); 


        }
    }
}
