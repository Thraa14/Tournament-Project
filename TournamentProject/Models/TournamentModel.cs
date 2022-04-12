using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentProject.Models
{
    public class TournamentModel
    {
        public event EventHandler<DateTime> OnCompleteTournament;
        public int tournamentID { get; set; }
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        public List<List<MatchUpModel>> Rounds { get; set; } = new List<List<MatchUpModel>>();

        public void CompleteTournament()
        {
            OnCompleteTournament?.Invoke(this, DateTime.Now);
        }

    }
}
