using RoverMissions.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverMissions.Models
{
    public class Mission
    {
        public ICollection<Command> Commands { get; private set; }
        public GridPosition StartPosition { get; private set; }

        public Mission(GridPosition startPos, ICollection<Command> commands)
        {
            this.Commands = commands;
            this.StartPosition = startPos;
        }
    }
}
