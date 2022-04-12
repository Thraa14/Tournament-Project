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
    public partial class DashBoardForm : Form
    {
        List<TournamentModel> Tournaments = GlobalConfig.Connection.GetTournament_All();
        public DashBoardForm()
        {
            InitializeComponent();
            WireUpList();
        }
        private void WireUpList()
        {
            TournamentDropDown.DataSource = Tournaments;
            TournamentDropDown.DisplayMember = "TournamentName";
        }
        private void LoadTournamentButton_Click(object sender, EventArgs e)
        {
            TournamentModel tm = (TournamentModel) TournamentDropDown.SelectedItem ;
            TournamentViewer form = new TournamentViewer(tm);
            form.Show();
        }

        private void TournamentDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            CreateTournamentForm form = new CreateTournamentForm();
            form.Show();
        }
    }
}
