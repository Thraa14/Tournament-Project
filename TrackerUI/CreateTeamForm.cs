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
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> AvailableTeamMember = GlobalConfig.Connection.GetPerson_All();
    
        private List<PersonModel> SelectedTeamMember = new List<PersonModel>();

        private ITeamRequestor CallingForm;
        public CreateTeamForm(ITeamRequestor Caller)
        {
            InitializeComponent();
           // CreateSampleData();
            WireUpList();
            CallingForm = Caller;
        }

        public void WireUpList()
        {
            SelectTeamDropDown.DataSource = null;

            SelectTeamDropDown.DataSource = AvailableTeamMember;
            SelectTeamDropDown.DisplayMember = "FullName";

            TournamentPlayerListBox.DataSource = null;

            TournamentPlayerListBox.DataSource = SelectedTeamMember;
            TournamentPlayerListBox.DisplayMember = "FullName";

        }

        public void CreateSampleData()
        {
            AvailableTeamMember.Add(new PersonModel { FirstName = "mm", LastName = "nn" });
            AvailableTeamMember.Add(new PersonModel { FirstName = "Another", LastName = "person" });


            SelectedTeamMember.Add(new PersonModel { FirstName = "muh", LastName = "muh" });
            SelectedTeamMember.Add(new PersonModel { FirstName = "other", LastName = "one" });


        }
        private void CreateTeamForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel) SelectTeamDropDown.SelectedItem;
            if (p != null)
            {
                AvailableTeamMember.Remove(p);
                SelectedTeamMember.Add(p);

                WireUpList();
            }
        }

        private void TeamNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TournamentPlayerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = TeamNameTextBox.Text;
            t.TeamMembers = SelectedTeamMember;

            GlobalConfig.Connection.CreateTeam(t);

            CallingForm.TeamComplete(t);
            this.Close();
        }

        private bool ValidateForm()
        { // to check info writen to the form to validate them
            if (FirstNameTextBox.Text.Length == 0)
            {
                return false;
            }
            if (SecondNameTextBox.Text.Length == 0)
            {
                return false;
            }
            if (EmailTextBox.Text.Length == 0)
            {
                return false;
            }
            if (CellphoneTextBox.Text.Length == 0)
            {
                return false;
            }

            return true;    
        }

        private void CreateMemberButton_click(object sender, EventArgs e)
        {
            if (ValidateForm())
            { // when form is valide we save the info the clear the form 
                PersonModel p = new PersonModel();

                p.FirstName = FirstNameTextBox.Text;
                p.LastName = SecondNameTextBox.Text;
                p.EmailAddress = EmailTextBox.Text;
                p.CellPhone = CellphoneTextBox.Text;

                GlobalConfig.Connection.CreatePerson(p); // save the form
                
                SelectedTeamMember.Add(p); // to add the new member to the player listbox.
                WireUpList();

                FirstNameTextBox.Text = " "; // clear the form
                SecondNameTextBox.Text = " ";
                EmailTextBox.Text = " ";
                CellphoneTextBox.Text = " ";


                
            }
            else
            {
                MessageBox.Show("This form has invalid information, You need to fill all the fields. Please try again! ");
            }

        }

        private void SelectTeamDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RemoveSelectedButton(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)TournamentPlayerListBox.SelectedItem;

            if (p != null)
            {
                SelectedTeamMember.Remove(p);
                AvailableTeamMember.Add(p);

                WireUpList();
            }


        }
    }
}
