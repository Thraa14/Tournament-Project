using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentProject.Models;

namespace TournamentProject.DataAccess
{
    public interface IDataConnection
    {
        void CreatePrize (PrizeModel model );
        void CreatePerson ( PersonModel model );
        void CreateTeam ( TeamModel model );
        void CreateTournament ( TournamentModel model );
        void UpdateMatchups ( MatchUpModel model );
        List<TeamModel> GetTeam_All();
        List<PersonModel> GetPerson_All();
        List<TournamentModel> GetTournament_All();

    }
}
