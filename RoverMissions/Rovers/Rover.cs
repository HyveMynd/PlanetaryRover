using RoverMissions.Enums;
using RoverMissions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverMissions.Rovers
{
    public interface Rover
    {
        /// <summary>
        /// Give the rover the order to execute the sequence of commands. If the mission succeeds the final position
        /// is returned, otherwise, the mission fails and its last known position is returned.
        /// </summary>
        /// <param name="commands"></param>
        Tuple<bool, GridPosition> ExecuteMission(GridPosition startPos, IEnumerable<Command> commands);
    }
}
