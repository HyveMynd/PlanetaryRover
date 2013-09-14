using RoverMissions.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverMissions.Models
{
    public class GridPosition
    {
        public readonly int XPos;
        public readonly int YPos;
        public readonly Orientation Direction;

        public GridPosition(int x, int y, Orientation direction)
        {
            this.XPos = x;
            this.YPos = y;
            this.Direction = direction;
        }
    }
}
