using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentProject.Models;
using TournamentProject.DataAccess.TextHelper;


namespace TournamentProject.DataAccess
{
    public class TextConnector : IDataConnection
    {
        // Load text file "Done in TextConnectorProcessor" 
        // Convert text file to list<prizemodel>  "Done in TextConnectorProcessor"
        // find the max id
        // Add new record with the new id (max+1)
        // convert the prizes to list<string> 
        // save list of string into file
        public void CreatePrize(PrizeModel model)
        {
            // to excute first 2 steps , load file and convert to list prizemodel
           List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();

            int currentID = 1; // to be able to find the max id 

            if ( prizes.Count > 0)
            {
                currentID = prizes.OrderByDescending(x => x.prizeID).First().prizeID + 1; //find max id 

            }

            model.prizeID = currentID;

            prizes.Add(model); // add new record with new max id 

            prizes.SaveToPrizeFile(); // convert and save 

        }
        public void CreatePerson(PersonModel model)
        {
            List<PersonModel> people = GlobalConfig.PersonFile.FullFilePath().LoadFile().ConvertToPersonModel();

            int currentID = 1;
            if (people.Count > 0)
            {
                currentID = people.OrderByDescending(x => x.personID).First().personID + 1; //find max id 

            }

            model.personID = currentID;

            people.Add(model); // add new record with new max id 

            people.SaveToPersonFile(); // convert and save 

        }
        public List<PersonModel> GetPerson_All()
        {
            return GlobalConfig.PersonFile.FullFilePath().LoadFile().ConvertToPersonModel();
        }
        public void CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel();
            
            int currentID = 1;
            if (teams.Count > 0)
            {
                currentID = teams.OrderByDescending(x => x.teamID).First().teamID + 1; //find max id 

            }

            model.teamID = currentID;

            teams.Add(model); // add new record with new max id 

            teams.SaveToTeamFile(); // convert and save 
        }
        public List<TeamModel> GetTeam_All()
        {
            return GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel();

        }
        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModel();

            int currentID = 1;
            if (tournaments.Count > 0)
            {
                currentID = tournaments.OrderByDescending(x => x.tournamentID).First().tournamentID + 1; //find max id 

            }

            model.tournamentID = currentID;

            model.SaveToRoundsFile();

            tournaments.Add(model); // add new record with new max id 

            tournaments.SaveToTournamentFile(); // convert and save 
            TournamentProcessor.UpdateTournamentResults(model);
        }
        public List<TournamentModel> GetTournament_All()
        {
            return GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModel();

        }
        public void UpdateMatchups(MatchUpModel model)
        {
            throw new NotImplementedException();
        }
    }
}
