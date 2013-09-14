using RoverMissions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverMissions.Parser
{
    /// <summary>
    /// Parses mission parameters.
    /// </summary>
    public interface IMissionParser
    {
        /// <summary>
        /// Returns the size of the mission area in cartesian coordinates.
        /// </summary>
        /// <returns></returns>
        Tuple<int, int> GetMapSize();

        /// <summary>
        /// Returns a collection of rover mission commands. Each mission is meant for a different rover.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Mission> GetMissions();
    }
}
