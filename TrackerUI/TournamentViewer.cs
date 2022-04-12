using System.ComponentModel;
using TournamentProject;
using TournamentProject.Models;

namespace TrackerUI
{
    public partial class TournamentViewer : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchUpModel> SelectedMatchups = new BindingList<MatchUpModel>();

        public TournamentViewer(TournamentModel tournamentModel)
        {
            InitializeComponent();
            tournament = tournamentModel;

            tournament.OnCompleteTournament += Tournament_OnCompleteTournament;

            WireUpList();
            LoadformData();
            LoadRounds();
        }

        private void Tournament_OnCompleteTournament(object? sender, DateTime e)
        {
            this.Close();
        }

        private void WireUpList()
        {
            RoundDropdown.DataSource = rounds;
            MatchupListBox.DataSource = SelectedMatchups;
            MatchupListBox.DisplayMember = "DisplayName";
        }

        private void LoadformData()
        {
            NameOFTournament.Text = tournament.TournamentName;
        }

        private void LoadRounds()
        {
            rounds.Clear();
            rounds.Add(1);
            int CurrRound = 1;

           
            foreach (List<MatchUpModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > CurrRound)
                {
                    CurrRound = matchups.First().MatchupRound;
                    rounds.Add(CurrRound);
                }
            }
            LoadMatchups(1);
        }
        private void LoadMatchups(int round)
        {
            foreach (List<MatchUpModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    SelectedMatchups.Clear();
                    foreach (MatchUpModel m in matchups)
                    {
                        if(m.Winner == null || !UnplayedCheckBox.Checked)
                        {
                            SelectedMatchups.Add(m);
                        }
                    }
                }

            }

            if(SelectedMatchups.Count > 0)
            {
                LoadSelectedMatchup(SelectedMatchups.First());
            }

            DisplayMatchupInfo();
        }

        private void DisplayMatchupInfo()
        {
            bool IsVisible = SelectedMatchups.Count > 0;

            Team1Label.Visible = IsVisible;
            Team2Label.Visible = IsVisible;
            Score1Label.Visible = IsVisible;
            Score2Label.Visible = IsVisible;
            ScoreTeam1Value.Visible = IsVisible;
            ScoreTeam2Value.Visible = IsVisible;
            VS.Visible = IsVisible;
            ScoreButton.Visible = IsVisible;

        }

        private void LoadSelectedMatchup(MatchUpModel m)
        {
            if (m?.Enteries != null)
            {
                for (int i = 0; i < m.Enteries.Count; i++)
                {
                    if (i == 0)
                    {
                        if (m.Enteries[0].TeamCompeting != null)
                        {
                            Team1Label.Text = m.Enteries[0].TeamCompeting.TeamName;
                            ScoreTeam1Value.Text = m.Enteries[0].Score.ToString();

                            Team2Label.Text = " <Bye>";
                            ScoreTeam2Value.Text = "0";

                        }

                        else
                        {
                            Team1Label.Text = "Not Yet Selected";
                            ScoreTeam1Value.Text = " ";
                        }
                    }
                    if (i == 1)
                    {
                        if (m.Enteries[1].TeamCompeting != null)
                        {
                            Team2Label.Text = m.Enteries[1].TeamCompeting.TeamName;
                            ScoreTeam2Value.Text = m.Enteries[1].Score.ToString();
                        }
                        else
                        {
                            Team2Label.Text = "Not Yet Selected";
                            ScoreTeam2Value.Text = " ";
                        }
                    }
                }
            }
        }

        private void RoundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)RoundDropdown.SelectedItem);
        }

        private void MatchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedMatchup((MatchUpModel)MatchupListBox.SelectedItem);
        }

        private void UnplayedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)RoundDropdown.SelectedItem);
        }

        private String ValidateData()
        {
            String ouput = "";
            double Team1Sore = 0;
            double Team2Sore = 0;
            bool ScoreValid1 = double.TryParse(ScoreTeam1Value.Text, out Team1Sore);
            bool ScoreValid2 = double.TryParse(ScoreTeam2Value.Text, out Team2Sore);

            if(!ScoreValid1)
            {
               ouput = " The Score One value is invalid number.";
            }
            else if (!ScoreValid2)
            {
                ouput = "The Score Two value is invalid number.";
            }

            else if (Team1Sore == 0 && Team2Sore == 0)
            {
                ouput = " You did Not enter a score for either Team!";
            }
            else if(Team1Sore == Team2Sore)
            {
                ouput= " We do Not handle Tie in this Application.";
            }

            return ouput;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ErrorMessage = ValidateData();
            if (ErrorMessage.Length > 0)
            {
                MessageBox.Show($" Input Error :{ ErrorMessage }");
                return;
            }

            MatchUpModel m = (MatchUpModel)MatchupListBox.SelectedItem;
            double Team1Sore = 0;
            double Team2Sore = 0;

            for (int i = 0; i < m.Enteries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Enteries[0].TeamCompeting != null)
                    {
                        bool ScoreValid = double.TryParse(ScoreTeam1Value.Text, out Team1Sore);
                        if (ScoreValid)
                        {
                            m.Enteries[0].Score = Team1Sore;
                        }
                        else
                        {
                            MessageBox.Show("Please insert valid score for Team 1");
                            return;
                        }
                    }
                    
                }

                if (i == 1)
                {
                    if (m.Enteries[1].TeamCompeting != null)
                    {
                        bool ScoreValid = double.TryParse(ScoreTeam2Value.Text, out Team2Sore);

                        if (ScoreValid)
                        {
                            m.Enteries[1].Score = Team2Sore;
                        }
                        else
                        {
                            MessageBox.Show("Please insert valid score for Team 2");
                            return;
                        }
                    }
                }

            }

            try
            {
                TournamentProcessor.UpdateTournamentResults(tournament);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"The Appliaction had the following Error {ex.Message}");
                return;
            } 
            
            LoadMatchups((int)RoundDropdown.SelectedItem);
        }
        private void TournamentViewer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Score1_Click(object sender, EventArgs e)
        {

        }

        private void Team2_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxScoreTeam2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxScoreTeam1_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}