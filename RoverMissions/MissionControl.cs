using RoverMissions.Models;
using RoverMissions.Rovers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverMissions
{
    public class MissionControl
    {
        public Tuple<int, int> MapSize { get; private set; }
        private ICollection<Rover> Rovers { get; set; }

        /// <summary>
        /// Creates mission control for the given map size.
        /// </summary>
        /// <param name="mapSize"></param>
        public MissionControl(Tuple<int, int> mapSize)
        {
            this.MapSize = mapSize;
        }

        /// <summary>
        /// Deploys a rover for every mission recieved. Rovers already deployed are reassigned to the new mission area.
        /// Return a list of rover locations with the status of the executed mission.
        /// </summary>
        /// <param name="missions"></param>
        /// <returns></returns>
        public IEnumerable<Tuple<bool, GridPosition>> ExecuteMissions(IEnumerable<Mission> missions)
        {
            var missionResults = new List<Tuple<bool, GridPosition>>();
            Rovers = new List<Rover>();
            // Add one rover for every mission
            foreach (var mission in missions)
            {
                Rover rover = new MarsRover(MapSize);
                Rovers.Add(rover);
                missionResults.Add(rover.ExecuteMission(mission.StartPosition, mission.Commands));
            }
            return missionResults;
        }
    }
}
