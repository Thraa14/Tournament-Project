using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentProject.Models;

namespace TournamentProject.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public void CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.ConString("TournamentConnectionString")))
            {
                Console.WriteLine(GlobalConfig.ConString("TournamentConnectionString"));

                var p = new DynamicParameters();

                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@Email", model.EmailAddress);
                p.Add("@CellPhone", model.CellPhone);

                connection.Execute("InsertPerson", p, commandType: CommandType.StoredProcedure);
            }
        }
        public void CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.ConString("TournamentConnectionString")))
            {
                Console.WriteLine(GlobalConfig.ConString("TournamentConnectionString"));

                var p = new DynamicParameters();
                // p.Add("@prizeID", model.prizeID);
                p.Add("@placeNumber", model.PlaceNumber);
                p.Add("@placeName", model.PlaceName);
                p.Add("@prizeAmount", model.PrizeAmount);
                p.Add("@prizePercentage", model.PrizePercentage);

                string sql = @" INSERT into prizes ( PlaceNumber, PlaceName, PrizeAmount, PrizePercentage)
VALUES( @placeNumber  ,@placeName , @prizeAmount, @prizePercentage );
                    select LAST_INSERT_ID();
";
                model.prizeID = connection.ExecuteScalar<int>(sql, new { PlaceNumber = model.PlaceNumber, PlaceName = model.PlaceName, PrizeAmount = model.PrizeAmount, PrizePercentage = model.PrizePercentage });
            }
        }
        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;

            using (IDbConnection connection = new MySqlConnection(GlobalConfig.ConString("TournamentConnectionString")))

                output = connection.Query<PersonModel>("GetPerson").ToList();

            return output;

        }
        public void CreateTeam(TeamModel model)
        {
            // TODO -- SQL Create Team form Msh sha3'alaa :) 
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.ConString("TournamentConnectionString")))
            {
                Console.WriteLine(GlobalConfig.ConString("TournamentConnectionString"));

                string sql = @"INSERT INTO TEAMS (TeamName) VALUES (@TeamName); 
                    SELECT LAST_INSERT_ID();
                    ";
                model.teamID = connection.ExecuteScalar<int>(sql, new { TeamName = model.TeamName });

                var p = new DynamicParameters();

                p.Add("@TeamName", model.TeamName);
                p.Add("@TeamID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                foreach (PersonModel tm in model.TeamMembers)
                // to loop over the team members in one team and get their IDs.
                {
                    p = new DynamicParameters();
                    p.Add("@teamID", model.teamID);
                    p.Add("@personID", tm.personID);

                    string sql2 = @"INSERT INTO teammembers (teamID , personID) VALUES (@teamID, @personID); 
                    SELECT LAST_INSERT_ID();
                    ";
                    connection.ExecuteScalar<int>(sql2, new { teamID = model.teamID, personID = tm.personID });

                }
            }
        }
        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> output;

            using (IDbConnection connection = new MySqlConnection(GlobalConfig.ConString("TournamentConnectionString")))

            {
                output = connection.Query<TeamModel>("GetTeam").ToList();

                foreach (TeamModel team in output)
                {
                    var p = new DynamicParameters();

                    p.Add("@Team_ID", team.teamID);

                    team.TeamMembers = connection.Query<PersonModel>("GetTeamMembers", p, commandType: CommandType.StoredProcedure).ToList();

                }
            }
            return output;
        }
        public void CreateTournament(TournamentModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.ConString("TournamentConnectionString")))
            {
                Console.WriteLine(GlobalConfig.ConString("TournamentConnectionString"));

                SaveTournament(connection, model);
                SaveTournamentPrizes(connection, model);
                SaveTournamentEntries(connection, model);
                SaveToTouramentRounds(connection, model);
                TournamentProcessor.UpdateTournamentResults(model);
            }

        }
        // For CreateTournament:
        // SaveTournament to update tournaments table,
        // SaveTournamentPrizes to update tournament prizes table,
        // SaveTournamentEntries to update tournament entries.
        private void SaveTournament(IDbConnection connection, TournamentModel model)
        {
            var p = new DynamicParameters();
            p.Add("@tournamentName", model.TournamentName);
            p.Add("@EntryFee", model.EntryFee);
            p.Add("@Tournamentid", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            string Sql = @" INSERT into tournaments (tournamentName, EntryFee ) VALUES( @tournamentName , @EntryFee );
                    select LAST_INSERT_ID();
                ";
            model.tournamentID = connection.ExecuteScalar<int>(Sql, new { tournamentName = model.TournamentName, EntryFee = model.EntryFee });
        }
        private void SaveTournamentPrizes(IDbConnection connection, TournamentModel model)
        {
            foreach (PrizeModel Pz in model.Prizes)
            {
                var p = new DynamicParameters();
                p.Add("@Tournamentid", model.tournamentID);
                p.Add("@prizeID", Pz.prizeID);
                p.Add("@tournamentPrizesID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                string sql2 = @" INSERT into tournamentprizes (prizeID , Tournamentid ) VALUES( @prizeID , @Tournamentid);
                    select LAST_INSERT_ID();
                ";

                connection.ExecuteScalar<int>(sql2, new { prizeID = Pz.prizeID, Tournamentid = model.tournamentID });

            }
        }
        private void SaveTournamentEntries(IDbConnection connection, TournamentModel model)
        {
            foreach (TeamModel tm in model.EnteredTeams)
            {
                var p = new DynamicParameters();
                p.Add("@Tournamentid", model.tournamentID);
                p.Add("@teamID", tm.teamID);
                p.Add("@entriesID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                string sql2 = @" INSERT into tournamententries ( Tournamentid , teamID ) VALUES( @Tournamentid , @teamID);
                    select LAST_INSERT_ID();
                ";
                connection.ExecuteScalar<int>(sql2, new { Tournamentid = model.tournamentID, teamID = tm.teamID });
            }
        }
        private void SaveToTouramentRounds(IDbConnection connection, TournamentModel model)
        {
            // we have to save: List<List<MatchUpModel>> Rounds && List<MatchUpEnteryModel> Enteries
            // loop through the rounds
            // loop though the matchups &  save the matchups
            // loop through the entries & save the entries.

            foreach (List<MatchUpModel> round in model.Rounds)
            {
                foreach (MatchUpModel matchup in round)
                {
                    var p = new DynamicParameters();
                    p.Add("@MatchupRound", matchup.MatchupRound);
                    p.Add("@Tournamentid", model.tournamentID);
                    p.Add("@matchUpID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                    string sql = @" INSERT into matchups ( MatchupRound , Tournamentid ) VALUES( @MatchupRound , @Tournamentid);
                    select LAST_INSERT_ID();   ";
                    matchup.matchUpID = connection.ExecuteScalar<int>(sql, new { MatchupRound = matchup.MatchupRound, Tournamentid = model.tournamentID });

                    foreach (MatchUpEnteryModel Entry in matchup.Enteries)
                    {
                        p = new DynamicParameters();
                        p.Add("@parentMatchUpID", Entry.ParentMatchup?.matchUpID);
                        p.Add("@teamCompetingID", Entry.TeamCompeting?.teamID);
                        p.Add("@matchUpID", matchup.matchUpID);
                        p.Add("@matchUpEntriesID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                        string sql2 = @" INSERT into matchupentries ( parentMatchUpID, teamCompetingID, matchUpID ) VALUES( @parentMatchUpID, @teamCompetingID, @matchUpID);
                        select LAST_INSERT_ID();  ";
                        connection.ExecuteScalar<int>(sql2, new { MatchupRound = matchup.MatchupRound, parentMatchUpID = Entry.ParentMatchup?.matchUpID, teamCompetingID = Entry.TeamCompeting?.teamID, matchUpID = matchup.matchUpID });
                    }

                }
            }

        }
        public List<TournamentModel> GetTournament_All()
        {
            List<TournamentModel> output;
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.ConString("TournamentConnectionString")))
            {
                output = connection.Query<TournamentModel>("GetTournament").ToList();
                // GetTournament: TouranamentID ,TournamentName , Entry Fee 
                var p = new DynamicParameters();

                foreach (TournamentModel t in output)
                {
                    // Populate Prizes
                    p = new DynamicParameters();
                    p.Add("@Tournamentid", t.tournamentID);

                    string sql = @" Select * from prizes inner join tournamentPrizes on prizes.prizeID = tournamentPrizes.prizeID where tournamentPrizes.TournamentID = @Tournamentid;
                          ";
                    t.Prizes = connection.Query<PrizeModel>(sql,p).ToList();

                    p = new DynamicParameters();
                    p.Add("@Tournamentid", t.tournamentID);
                    string sql1 = @" Select * from teams inner join tournamentEntries on teams.teamID = tournamentEntries.teamID where tournamentEntries.TournamentID = @Tournamentid ;
                          ";
                    t.EnteredTeams = connection.Query<TeamModel>(sql1, p).ToList();
                    /////////////////////////////////////////////////
                    if (t.EnteredTeams != null)
                    {
                        foreach (TeamModel team in t.EnteredTeams)
                        {
                            // Populate teams 
                            p = new DynamicParameters();
                            p.Add("@teamID", team.teamID);
                            string sql2 = @" Select * from teams inner join tournamentEntries on teams.teamID = tournamentEntries.teamID where teams.teamID = @teamID ;
                         ";
                            team.TeamMembers = connection.Query<PersonModel>(sql2, p).ToList();
                        }
                    }
                    /////////// Populate Rounds : List<List<MatchupModel>>.
                    p = new DynamicParameters();
                    p.Add("@Tournamentid", t.tournamentID);
                    string sql3 = @" Select * from matchups where Tournamentid = @Tournamentid order by MatchupRound ";
                    List<MatchUpModel> matchups =  connection.Query<MatchUpModel>(sql3, p).ToList();

                    if (matchups != null)
                    {
                        foreach (MatchUpModel m in matchups)
                        {
                            p = new DynamicParameters();
                            p.Add("@matchUpID", m.matchUpID);
                            string sql4 = @" Select * from matchUpEntries where matchUpID = @matchUpID ";
                           m.Enteries = connection.Query<MatchUpEnteryModel>(sql4, p).ToList();

                            // populate each matchup (1 model)

                            List<TeamModel> AllTeams = GetTeam_All();
                            if (m.winnerId > 0)
                            {
                                m.Winner = AllTeams.Where(x => x.teamID == m.winnerId).First();
                            }

                            foreach (var matchupEntry in m.Enteries)
                            {
                                // populate each Entry (2 models)
                                if (matchupEntry.teamCompetingID > 0)
                                {
                                    matchupEntry.TeamCompeting = AllTeams.Where(t => t.teamID == matchupEntry.teamCompetingID).First();
                                }
                                if (matchupEntry.parentMatchUpID > 0)
                                {
                                    matchupEntry.ParentMatchup = matchups.Where(x => x.matchUpID == matchupEntry.parentMatchUpID).First();
                                }

                            }
                        }

                        // To load the Rounds .. List of list matchupModels
                        List<MatchUpModel> CurrRow = new List<MatchUpModel>();
                        int CurrRound = 1;

                        foreach (MatchUpModel m in matchups)
                        {
                            if (m.MatchupRound > CurrRound)
                            {
                                t.Rounds.Add(CurrRow); // list of matchup model.
                                CurrRow = new List<MatchUpModel>();
                                CurrRound++;
                            }

                            CurrRow.Add(m);
                        }
                        t.Rounds.Add(CurrRow);

                    }
                }
                return output;
            }
        }
        public void UpdateMatchups(MatchUpModel model)
        {
            using (IDbConnection connection = new MySqlConnection(GlobalConfig.ConString("TournamentConnectionString")))
            {
                var p = new DynamicParameters();

                if (model.Winner != null)
                {
                    p.Add("@winnerId", model.Winner.teamID);
                    p.Add("@matchUpID", model.matchUpID);

                    string sql = @" update matchups set winnerId = @winnerId where matchUpID =@matchUpID ;
                          ";
                    connection.Execute(sql, new { winnerId = model.Winner.teamID, matchUpID = model.matchUpID });
                }
                foreach (MatchUpEnteryModel me in model.Enteries)
                {
                    if(me.TeamCompeting != null)
                    {
                        p = new DynamicParameters();
                        p.Add("@matchUpEntriesID", me.matchUpEntriesID);
                        p.Add("@teamCompetingID", me.TeamCompeting.teamID);
                        p.Add("@Score", me.Score);
                        string sql1 = @" update matchupentries set teamCompetingID = @teamCompetingID, Score = @Score where matchUpEntriesID= @matchUpEntriesID ;
                            ";
                        connection.Execute(sql1, new { matchUpEntriesID = me.matchUpEntriesID, teamCompetingID = me.TeamCompeting.teamID, Score = me.Score });
                    }

                }


            }

        }
    }
}