using System.Configuration;
using System.Text;
using TournamentProject.Models;

namespace TournamentProject
{
    public static class TournamentProcessor
    {
        // Order our list of teams randomly
        // take that list and check if its big enough (2^n) , if not add byes.
        // create ouf first round of matchups
        // create every round after that .. (N/2), N: number of teams in pervious rounds. i.e:(8,4,2,1) matchups
        public static void CreateRounds(TournamentModel model)
        { // The main function that call the sub functions to get the job done.
            List<TeamModel> RandomizedTeams = RandomizeTeamOrder(model.EnteredTeams);
            int rounds = FindNoOfRounds(RandomizedTeams.Count);
            int byes = NoOfByes(rounds, RandomizedTeams.Count);
            model.Rounds.Add(CreateFirstRound(byes, RandomizedTeams));
            CreateOtherRounds(model, rounds);
        }

        public static void UpdateTournamentResults(TournamentModel model)
        {
            int StartingRound = model.CheckCurrRound();

            List<MatchUpModel> toScore = new List<MatchUpModel>();

            foreach (List<MatchUpModel> round in model.Rounds)
            {
                foreach (MatchUpModel rm in round)
                {
                    if (rm.Winner == null && (rm.Enteries.Any(x => x.Score != 0 || rm.Enteries.Count == 1)))
                    {
                        toScore.Add(rm);
                    }
                }
            }
            MarkWinners(toScore);
            AdvanceWinners(toScore, model);
            toScore.ForEach(x => GlobalConfig.Connection.UpdateMatchups(x));

            int EndingRound = model.CheckCurrRound();

            if (EndingRound > StartingRound)
            {
                model.AlertUsersToNewRound();
            }
        }

        private static void MarkWinners(List<MatchUpModel> models)
        {
           string GreaterWins = ConfigurationManager.AppSettings["GreaterWins"];

            foreach (MatchUpModel m in models)
            {
                if (m.Enteries.Count == 1)
                { // to handle byees.
                    m.Winner = m.Enteries[0].TeamCompeting;
                    continue;
                }

                if (GreaterWins == "0")
                {   // 0 means false ,  low score wins
                    if (m.Enteries[0].Score < m.Enteries[1].Score)
                    {
                        m.Winner = m.Enteries[0].TeamCompeting;
                    }
                    else if (m.Enteries[1].Score < m.Enteries[0].Score)
                    {
                        m.Winner = m.Enteries[1].TeamCompeting;
                    }
                    else
                    {
                        throw new Exception("We do NOT allow ties in this App.");
                    }

                }
                else
                {   // 1 means true, higher score wins.
                    if (m.Enteries[0].Score > m.Enteries[1].Score)
                    {
                        m.Winner = m.Enteries[0].TeamCompeting;
                    }
                    else if (m.Enteries[1].Score > m.Enteries[0].Score)
                    {
                        m.Winner = m.Enteries[1].TeamCompeting;
                    }
                    else
                    {
                        throw new Exception("We do NOT allow ties in this App.");
                    }
                }
            }
            //if (Team1Sore > Team2Sore)
            //{
            //    // Team 1 wins 
            //    m.Winner = m.Enteries[0].TeamCompeting;
            //}
            //else if (Team2Sore > Team1Sore)
            //{
            //    m.Winner = m.Enteries[1].TeamCompeting;
            //}
            //else
            //{
            //    MessageBox.Show(" We Don't handle Tie win.");
            //}
        }

        private static void AdvanceWinners(List<MatchUpModel> models, TournamentModel tournament)
        {
            foreach (MatchUpModel m in models)
            {
                foreach (List<MatchUpModel> round in tournament.Rounds)
                {
                    foreach (MatchUpModel rm in round)
                    {
                        foreach (MatchUpEnteryModel me in rm.Enteries)
                        {
                            if (me.ParentMatchup != null)
                            {
                                if (me.ParentMatchup.matchUpID == m.matchUpID)
                                {
                                    me.TeamCompeting = m.Winner;
                                    GlobalConfig.Connection.UpdateMatchups(rm);
                                }
                            }
                        }
                    }
                }
            }
        }

        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {        // Order our list of teams randomly
            return teams.OrderBy(x => Guid.NewGuid()).ToList();

        }
        private static int FindNoOfRounds(int TeamCount)
        { // take that list and check if its big enough (2^n)
            int output = 1;
            int val = 2;

            while (val < TeamCount)
            {
                output++;
                val *= 2;
            }

            return output;
        }

        private static int NoOfByes(int rounds, int NoOfTeams)
        {
            int output = 0;
            int TotalTeams = 1;

            for (int i = 1; i <= rounds; i++)
            {
                TotalTeams *= 2;  // to get the 2^n 
            }
            output = TotalTeams - NoOfTeams;

            return output; // output is the number of byes
        }

        private static List<MatchUpModel> CreateFirstRound(int Byes, List<TeamModel> teams)
        {
            List<MatchUpModel> output = new List<MatchUpModel>();
            MatchUpModel current = new MatchUpModel();

            foreach (TeamModel team in teams)
            {
                current.Enteries.Add(new MatchUpEnteryModel { TeamCompeting = team });

                if (Byes > 0 || current.Enteries.Count > 1)
                {
                    current.MatchupRound = 1; // as this is only for the first round
                    output.Add(current);
                    current = new MatchUpModel();

                    if (Byes > 0)
                    {
                        Byes--;
                    }
                }
            }

            return output;

        }

        private static void CreateOtherRounds(TournamentModel model, int NoOfRounds)
        {
            int round = 2; // as round 2 is already done.
            List<MatchUpModel> PreviousRound = model.Rounds[0]; // to get the previous round which is the 1st round
            List<MatchUpModel> CurrRound = new List<MatchUpModel>();
            MatchUpModel CurrMatchUp = new MatchUpModel();

            while (round <= NoOfRounds)
            {
                foreach (MatchUpModel match in PreviousRound)
                {
                    CurrMatchUp.Enteries.Add(new MatchUpEnteryModel { ParentMatchup = match });

                    if (CurrMatchUp.Enteries.Count > 1)
                    {
                        CurrMatchUp.MatchupRound = round;  // to assign the current round we are in in this loop.
                        CurrRound.Add(CurrMatchUp); // added the matchup to the round
                        CurrMatchUp = new MatchUpModel(); // clean up the currmatchup to take a new matchup 
                    }
                }

                model.Rounds.Add(CurrRound); // add current round to the rest of the rounds.
                PreviousRound = CurrRound; // so now the previous round is 2 and create round 3 ... 
                CurrRound = new List<MatchUpModel>(); // clean up the currround to take the new round (3)
                round++;

            }
        }

        private static int CheckCurrRound(this TournamentModel model)
        {
            int output = 1;

            foreach (List<MatchUpModel> round in model.Rounds)
            {
                if (round.All(x => x.Winner != null))
                {
                    output++;
                }
                else
                {
                    return output;
                }
            }

            // Tournament is Complete.
            CompleteTournament(model);

            return output - 1;
        }

        private static void CompleteTournament(TournamentModel model)
        {
            TeamModel Winners = model.Rounds.Last().First().Winner;
            TeamModel RunnerUp = model.Rounds.Last().First().Enteries.Where(x => x.TeamCompeting != Winners).First().TeamCompeting;
            decimal WinnerPrize = 0;
            decimal RunnerUpPrize = 0;

            if (model.Prizes.Count > 0)
            {
                decimal TotalIncome = model.EnteredTeams.Count * model.EntryFee;
                PrizeModel FirstPlacePrize = model.Prizes.Where(x => x.PlaceNumber == 1).FirstOrDefault();
                PrizeModel SecondPlacePrize = model.Prizes.Where(x => x.PlaceNumber == 2).FirstOrDefault();

                if (FirstPlacePrize != null)
                {
                    WinnerPrize = FirstPlacePrize.CalculatePrizePayment(TotalIncome);
                }
                if (SecondPlacePrize != null)
                {
                    WinnerPrize = SecondPlacePrize.CalculatePrizePayment(TotalIncome);
                }
            }

            // Send Email to all Tournament.
            string subject = "";
            StringBuilder body = new StringBuilder();

            subject = $" In { model.TournamentName },{ Winners.TeamName} has won!";

            body.AppendLine("<h1> We Have a WINNER! </h1>");
            body.Append("<strong> Congratulations </strong>");
            body.AppendLine();
            body.AppendLine();
            if (WinnerPrize > 0)
            {
                body.AppendLine($"<p>{Winners.TeamName} has recived ${WinnerPrize}</p>");
            }
            if (RunnerUpPrize > 0)
            {
                body.AppendLine($"<p>{RunnerUp.TeamName} has recived ${RunnerUpPrize}</p>");
            }

            body.AppendLine();
            body.AppendLine("<p>Thanks For Great Tournament! </p>");
            body.AppendLine("~ Tournament Tracker");

            List<string> bcc = new List<string>();

            foreach (TeamModel t in model.EnteredTeams)
            {
                foreach (PersonModel p in t.TeamMembers)
                {
                    if (p?.EmailAddress?.Length > 0)
                    {
                        bcc.Add(p.EmailAddress);
                    }
                }
            }

           //  EmailLogic.SendingEmail(new List<string>(), bcc, subject, body.ToString());

            // Complete Tournament
            model.CompleteTournament();
        }

        private static decimal CalculatePrizePayment(this PrizeModel prize, decimal totalIncome)
        {
            decimal output = 0;
            if (prize.PrizeAmount > 0)
            {
                output = prize.PrizeAmount;
            }
            else
            {
                output = decimal.Multiply(totalIncome, Convert.ToDecimal(prize.PrizePercentage / 100));
            }

            return output;
        }

        public static void AlertUsersToNewRound(this TournamentModel model)
        {
            int CurrentRoundNumber = model.CheckCurrRound();
            List<MatchUpModel> CurrentRound = model.Rounds.Where(x => x.First().MatchupRound == CurrentRoundNumber).First();

            foreach (MatchUpModel Matchup in CurrentRound)
            {
                foreach (MatchUpEnteryModel me in Matchup.Enteries)
                {
                    foreach (PersonModel p in me.TeamCompeting.TeamMembers)
                    {
                        AlertPersonToNewRound(p, me.TeamCompeting.TeamName, Matchup.Enteries.Where(x => x.TeamCompeting != me.TeamCompeting).FirstOrDefault());
                    }
                }
            }
        }

        private static void AlertPersonToNewRound(PersonModel p, string teamName, MatchUpEnteryModel Competitor)
        {
            if (p?.EmailAddress?.Length == 0)
            {
                return;
            }

            string to = "";
            string subject = "";
            StringBuilder body = new StringBuilder();

            if (Competitor != null)
            {
                subject = $"You have a new matchup with{ Competitor.TeamCompeting.TeamName }";

                body.AppendLine("<h1> You have a new matchup! </h1>");
                body.Append("<strong> Competitor </strong>");
                body.Append(Competitor.TeamCompeting.TeamName);
                body.AppendLine();
                body.AppendLine();
                body.AppendLine("Have a Great Line!");
                body.AppendLine("~ Tournament Tracker");
            }
            else
            {
                subject = "You have a bye week this round";
                body.AppendLine("Enjoy Your Round off!");
                body.AppendLine("~ Tournament Tracker");

            }

            to = p.EmailAddress;

          // EmailLogic.SendingEmail( to, subject, body.ToString());
        }
    }
}
