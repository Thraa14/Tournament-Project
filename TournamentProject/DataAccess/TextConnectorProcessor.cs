using System.Configuration;
using TournamentProject.Models;

namespace TournamentProject.DataAccess.TextHelper
{
    // Load text file "Done here" 
    // Convert text file to list<prizemodel>  "Done here"
    // find the max id
    // Add new record with the new id (max+1)
    // convert the prizes to list<string>
    // save list of string into file
    public static class TextConnectorProcessor
    {
        public static string FullFilePath ( this string filename) 
        // to return full path of file with its name
        {
            return $"{ ConfigurationManager.AppSettings["FilePath"] }\\{ filename }";
        }
        public static List<string> LoadFile (this string file)
        { //load the file and return the containing of the file in string
            if (!File.Exists(file))
            {
                return new List<string>();

            }
            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel>  ConvertToPrizeModel (this List<string> lines)
        { // convert string from the file into list of prize models.
            List<PrizeModel> output = new List<PrizeModel>();

            foreach(string line in lines)
            {
                PrizeModel p = new PrizeModel();
                string [] cols = line.Split(',');
                p.prizeID = int.Parse(cols[0]);
                ////////////////change
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);
            }
            return output;
        }

        public static void SaveToPrizeFile ( this List<PrizeModel> models)
        {
            List<string> lines = new List<string>();

            foreach ( PrizeModel p in models)
            {
                lines.Add($"{ p.prizeID },{ p.PlaceNumber },{ p.PlaceName },{ p.PrizeAmount }, { p.PrizePercentage }");
            }

            File.WriteAllLines(GlobalConfig.PrizesFile.FullFilePath(), lines);
        }

        public static List<PersonModel> ConvertToPersonModel(this List<string> lines)
        { // convert string from the file into list of person models.
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                PersonModel p = new PersonModel();
                string[] cols = line.Split(',');
                p.personID = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellPhone = cols[4];
                output.Add(p);
            }
            return output;
        }

        public static void SaveToPersonFile(this List<PersonModel> models)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{ p.personID },{ p.FirstName },{ p.LastName },{ p.EmailAddress },{ p.CellPhone }");
            }

            File.WriteAllLines(GlobalConfig.PersonFile.FullFilePath(), lines);
        }

        public static List<TeamModel> ConvertToTeamModel (
          this List<string> lines)
        {
            // id , team name , (list of person) 
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = GlobalConfig.PersonFile.FullFilePath().LoadFile().ConvertToPersonModel();
            foreach (string line in lines)
            {
                TeamModel t = new TeamModel();
                string[] cols = line.Split(',');
                t.teamID = int.Parse(cols[0]);
                t.TeamName = cols[1];
                 
                string[] PersonIDs = cols[2].Split('|');

                foreach( string id in PersonIDs)
                {
                    t.TeamMembers.Add(people.Where(x => x.personID == int.Parse(id)).First());
                }
                output.Add(t);
            }
            return output;

        }

        public static void SaveToTeamFile(this List<TeamModel> models )
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models)
            {
                lines.Add($"{ t.teamID },{ t.TeamName },{ ConvertPeopleListToString(t.TeamMembers) }");
            }
            File.WriteAllLines(GlobalConfig.TeamFile.FullFilePath(), lines);

        }

        private static string ConvertPeopleListToString( List<PersonModel> people)
        {
            // to adjust the list of people that will be displayed in team files, Called in SaveToTeamFile method.
            // 
            string output = " ";

            if (people.Count == 0) // to prevent error by output.length - 1 when no person in personmodel
            {
                return " ";
            }

            foreach (PersonModel p in people)
            { // 2|5| 
                output += $"{ p.personID }|";

            }
            output = output.Substring(0, output.Length-1); // to remove the last | writen by foreach

            return output;
        }


        // for tournament Form .............

        public static List<TournamentModel> ConvertToTournamentModel (
            this List<string> lines)

        {
            // id , TournamentName , EntryFee , (id|id|id -- Entered Teams) , (id|id|id -- Prizes) ,
            // (Rounds -list of list of matchups -- id^id^id | id^id^id )

            // id =0 ;
            // Tournament name = 1 
            // Entry fee = 2 ;
            // Entered Teams = 3 ;
            // Prizes = 4;
            // Rounds = 5

            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel();
            List<PrizeModel> Prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();
            List<MatchUpModel> matchups = GlobalConfig.MatchUpFile.LoadFile().ConvertToMatchUpModel();
            foreach (string line in lines)
            {
                TournamentModel tour = new TournamentModel();
                string[] cols = line.Split(',');

                tour.tournamentID = int.Parse(cols[0]);
                tour.TournamentName = cols[1];
                tour.EntryFee = decimal.Parse(cols[2]);


                string[] TeamsID = cols[3].Split('|');

                foreach (string id in TeamsID)
                {
                    tour.EnteredTeams.Add(teams.Where(x => x.teamID == int.Parse(id)).First());
                }

                if (cols[4].Length > 0)
                {
                    string[] PrizesID = cols[4].Split('|');

                    foreach (string id in PrizesID)
                    {
                        tour.Prizes.Add(Prizes.Where(x => x.prizeID == int.Parse(id)).First());
                    }
                }
               

                // To save the rounds 
                // Rounds -list of list of matchups -- id^id^id | id^id^id

                string[] rounds = cols[5].Split('|');
                List < MatchUpModel > ms = new List < MatchUpModel >();
                foreach (string round in rounds)
                {
                    string[] msText = round.Split('^');

                    foreach (string matchupTextID in msText)
                    {
                     ms.Add(matchups.Where(x => x.matchUpID == int.Parse(matchupTextID)).First());
                    }

                    tour.Rounds.Add(ms);
                }

              output.Add(tour);
            }

            return output;

        }

        public static void SaveToTournamentFile(this List<TournamentModel> models)
        {
            List<string> lines = new List<string>();

            foreach (TournamentModel t in models )
            {
                lines.Add($"{ t.tournamentID },{ t.TournamentName },{ t.EntryFee },{ ConvertTeamListToString (t.EnteredTeams)},{ ConvertPrizeListToString(t.Prizes) },{ ConvertRoundsListToString(t.Rounds)}");
            }
           File.WriteAllLines(GlobalConfig.TournamentFile.FullFilePath(), lines);

        }

        private static string ConvertTeamListToString(List<TeamModel> Team)
        {
            
            string output = " ";

            if (Team.Count == 0) // to prevent error by output.length - 1
            {
                return " ";
            }

            foreach (TeamModel t in Team)
            { 
                output += $"{ t.teamID }|";

            }
            output = output.Substring(0, output.Length - 1); // to remove the last | writen by foreach

            return output;
        }

        private static string ConvertPrizeListToString(List<PrizeModel> Prize)
        {
            string output = " ";

            if (Prize.Count == 0) // to prevent error by output.length - 1 
            {
                return " ";
            }

            foreach (PrizeModel p in Prize)
            {
                output += $"{ p.prizeID }|";

            }
            output = output.Substring(0, output.Length - 1); // to remove the last | writen by foreach

            return output;
        }

        private static string ConvertRoundsListToString(List<List<MatchUpModel>> rounds)
        {
            
            // Rounds list of lists ..  id^id^id | id^id^id 

            string output = " ";

            if (rounds.Count == 0) // to prevent error by output.length - 1
            {
                return " ";
            }

            foreach (List<MatchUpModel> r in rounds)
            {
                output += $"{ ConvertMatchupListToString(r) }|";

            }
            output = output.Substring(0, output.Length - 1); // to remove the last | writen by foreach

            return output;
        }

        private static string ConvertMatchupListToString(List<MatchUpModel> matchups)
        {
            string output = " ";

            if (matchups.Count == 0) // to prevent error by output.length - 1 
            {
                return " ";
            }

            foreach (MatchUpModel m in matchups)
            {
                output += $"{ m.matchUpID}^";

            }
            output = output.Substring(0, output.Length - 1); // to remove the last | writen by foreach

            return output;
        }

        public static void SaveToRoundsFile(this TournamentModel model)
        {
            // loop through each round 
            // loop through each matchup 
            // loop inside each matchup and save the records.
            // loop through each entry , get the id and save it.

            foreach (List<MatchUpModel> round in model.Rounds)
            {
                foreach (MatchUpModel matchup in round)
                {
                    // loop all the matchup from file 
                    //get the top id and add one 
                    // store the id & save the matchup record
                    matchup.SaveMatchUpToFile(); 
                }
            }
        }

        public static void SaveMatchUpToFile (this MatchUpModel matchup)
        {
            List<MatchUpModel> matchups = GlobalConfig.MatchUpFile.FullFilePath().LoadFile().ConvertToMatchUpModel();

            int currentID = 1;
            if (matchups.Count > 0)
            {
                currentID = matchups.OrderByDescending(x => x.matchUpID).First().matchUpID + 1; //find max id.
            }

            matchup.matchUpID = currentID;
            matchups.Add(matchup);

            foreach (MatchUpEnteryModel entry in matchup.Enteries)
            {
                entry.SaveEntryToFile();
            }

            // to save to file ..
            // id=0, Entries=3 (id|id|id) , winner = 2 , matchuprounds = 3 .
            List<string> lines = new List<string>();

            foreach (MatchUpModel m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.teamID.ToString();
                }
                lines.Add($"{ m.matchUpID },{ ConvertMatchupEntriesListToString(m.Enteries) },{ winner },{ m.MatchupRound }");
            }
            File.WriteAllLines(GlobalConfig.MatchUpFile.FullFilePath(), lines);

        }
        private static string ConvertMatchupEntriesListToString(List<MatchUpEnteryModel> entries)
        {
            string output = " ";

            if (entries.Count == 0) // to prevent error by output.length - 1 
            {
                return " ";
            }

            foreach (MatchUpEnteryModel e in entries)
            {
                output += $"{ e.matchUpEntriesID }|";

            }
            output = output.Substring(0, output.Length - 1); // to remove the last | writen by foreach

            return output;
        }

        public static void SaveEntryToFile(this MatchUpEnteryModel entry)
        {

            List<MatchUpEnteryModel> entries = GlobalConfig.MatchUpEntryFile.FullFilePath().LoadFile().ConvertToMatchUpEntryModel();

            // to find max id 
            int currentID = 1;
            if (entries.Count > 0)
            {
                currentID = entries.OrderByDescending(x => x.matchUpEntriesID).First().matchUpEntriesID + 1; //find max id 
            }

            entry.matchUpEntriesID = currentID;
            entries.Add(entry); // to the entry to the list of entries.

            // to save to file 
            // id =0 , teamcompeting = 1 , score = 2 , parentMatchup =3 

            List<string> lines = new List<string>();

            foreach (MatchUpEnteryModel e in entries )
            {
                string parent = "";
                if(e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.matchUpID.ToString();
                }
                string teamcompeting = "";
                if (e.TeamCompeting != null)
                {
                    teamcompeting = e.TeamCompeting.teamID.ToString();
                }

                lines.Add($"{ e.matchUpEntriesID },{ teamcompeting },{ e.Score },{ parent }");
            }
            File.WriteAllLines(GlobalConfig.MatchUpEntryFile.FullFilePath(), lines);

        }

        public static List<MatchUpModel> ConvertToMatchUpModel(this List<string> lines)
        {
            // id=0, Entries=3 (id|id|id) , winner = 2 , matchuprounds = 3 .
            List<MatchUpModel> output = new List<MatchUpModel>();
            
            foreach (string line in lines)
            {
                MatchUpModel m = new MatchUpModel();
                string[] cols = line.Split(',');
                m.matchUpID = int.Parse(cols[0]);
                m.Enteries = ConvertStringToMatchUpEntryModel(cols[1]);
                if(cols[2].Length == 0)
                {
                    m.Winner = null;
                }
                else
                {
                    m.Winner = LookUpTeamByID(int.Parse(cols[2]));

                }
                m.MatchupRound = int.Parse(cols[3]);
                output.Add(m);
            }
            return output;
        }

        private static List<MatchUpEnteryModel> ConvertStringToMatchUpEntryModel (string input)
        {
            string[] ids = input.Split('|');
            List<MatchUpEnteryModel> output = new List<MatchUpEnteryModel>();
            List<string> entries = GlobalConfig.MatchUpEntryFile.FullFilePath().LoadFile();
            List<string> matchupEntries = new List<string>();

            foreach (string id in ids )
            {
                foreach (string entry in entries)
                {
                    string [] cols = entry.Split(',');

                    if (cols[0]==id)
                    {
                        matchupEntries.Add(entry);
                    }
                }
            }
            output = matchupEntries.ConvertToMatchUpEntryModel();

            return output;

        }

        public static List <MatchUpEnteryModel> ConvertToMatchUpEntryModel (this List<string> lines)
        { // id =0 , teamcompeting = 1 , score = 2 , parentMatchup =3 
            List<MatchUpEnteryModel> output = new List<MatchUpEnteryModel>();

            foreach (string line in lines)
            {
                MatchUpEnteryModel me = new MatchUpEnteryModel();

                string[] cols = line.Split(',');
                me.matchUpEntriesID = int.Parse(cols[0]);

                if(cols[1].Length == 0)
                {
                    me.TeamCompeting = null;
                }
                else
                {
                    me.TeamCompeting = LookUpTeamByID(int.Parse(cols[1]));

                }
                me.Score = double.Parse(cols[2]);

                int ParentID = 0;
                if(int.TryParse(cols[3], out ParentID))
                {
                    me.ParentMatchup =LookUpMatchUpByID(int.Parse(cols[3]));
                }
                else
                {
                    me.ParentMatchup = null; 
                }

                output.Add(me);
            }

            return output;
        }

        private static TeamModel LookUpTeamByID (int id )
        {
            List<string> Teams = GlobalConfig.TeamFile.FullFilePath().LoadFile();
           
            foreach(string team in Teams)
            {
                string [] cols = team.Split(',');
                if (cols[0] == id.ToString())
                {
                    List<string> matchingTeams = new List<string>();
                    matchingTeams.Add(team);
                    return matchingTeams.ConvertToTeamModel().First();
                }
            }

            return null;
        }
        private static MatchUpModel LookUpMatchUpByID(int id)
        {
            List<string> matchups = GlobalConfig.MatchUpFile.FullFilePath().LoadFile();
            foreach (string matchup in matchups)
            {
                string[] cols = matchup.Split(',');
                if(cols[0]== id.ToString())
                {
                    List<string> matchingMatchup = new List<string>();
                    matchingMatchup.Add(matchup);
                    return matchingMatchup.ConvertToMatchUpModel().First();
                }

            }

            return null;
        }

    }

}
