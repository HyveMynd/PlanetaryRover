using RoverMissions;
using RoverMissions.Models;
using RoverMissions.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverGui
{
    public class RoverGuiController
    {
        private IMissionParser _parser;
        private MissionControl _missionControl;

        public void LoadMissionFile(string filename)
        {
            _parser = new TextParser(filename);
            _missionControl = new MissionControl(_parser.GetMapSize());
        }

        public IEnumerable<GridPosition> GetStartPositions()
        {
            var startPoses = new List<GridPosition>();
            foreach (var mission in _parser.GetMissions())
            {
                startPoses.Add(mission.StartPosition);
            }
            return startPoses;
        }

        public Tuple<int, int> GetMapSize()
        {
            return _parser.GetMapSize();
        }

        public IEnumerable<Tuple<bool, GridPosition>> ExecuteMission()
        {
            var results = _missionControl.ExecuteMissions(_parser.GetMissions());
            return results;
        }
    }
}
