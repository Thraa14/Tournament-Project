using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentProject.Models;

namespace TrackerUI
{
    public interface ITeamRequestor
    {
        public void TeamComplete(TeamModel model);

    }
}
