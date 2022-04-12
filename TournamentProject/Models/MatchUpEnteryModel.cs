using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentProject.Models
{
    public class MatchUpEnteryModel
    {
        public int matchUpEntriesID { get; set; }
        public int teamCompetingID { get; set; }
        public TeamModel TeamCompeting { get; set; }
        public double Score { get; set; }
        public int parentMatchUpID { get; set; }
        public MatchUpModel ParentMatchup { get; set; }
        /// Represent the match that this team came up from as a winner 
    }
}
