using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentProject.Models
{
    public class MatchUpModel
    {
        public int matchUpID { get; set; }
        public int MatchupRound { get; set; }
        public List<MatchUpEnteryModel> Enteries { get; set; } = new List<MatchUpEnteryModel>();
        public TeamModel Winner { get; set; }
        public int winnerId { get; set; }
        public string DisplayName
        { 
            get
            {
                string output = "";
                foreach (MatchUpEnteryModel me in Enteries)
                {
                    if (me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. {me.TeamCompeting.TeamName}";
                        }
                    }
                    else
                    {
                        output = "Matchup Not Yet Determined.";
                        break;
                    }
                   
                }

                return output;
            }
        }

    }
}
