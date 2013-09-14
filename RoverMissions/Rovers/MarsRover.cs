using RoverMissions.Enums;
using RoverMissions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverMissions.Rovers
{
    public class MarsRover : Rover
    {
        private Tuple<int, int> _mapSize;
        private GridPosition _startPos;
        public int CurrentX { get; private set; }
        public int CurrentY { get; private set; }
        public Orientation CurrentDirection { get; private set; }

        public MarsRover(Tuple<int, int> mapSize)
        {
            this._mapSize = mapSize;
        }

        public Tuple<bool, GridPosition> ExecuteMission(GridPosition startPos, IEnumerable<Command> commands)
        {
            this._startPos = startPos;
            CurrentX = startPos.XPos;
            CurrentY = startPos.YPos;
            CurrentDirection = startPos.Direction;

            foreach (var command in commands)
            {
                // Mission fails if the rover cannot move in that direction.
                if (!IsValidMove(command))
                {
                    return Tuple.Create(false, new GridPosition(CurrentX, CurrentY, CurrentDirection));
                }
                switch (command)
                {
                    case Command.M:
                        MoveRover();
                        break;
                    case Command.L:
                        TurnLeft();
                        break;
                    case Command.R:
                        TurnRight();
                        break;
                    default:
                        break;
                }
                
            }
            _startPos = new GridPosition(CurrentX, CurrentY, CurrentDirection);
            return Tuple.Create(true, _startPos);
        }

        private void TurnRight()
        {
            switch (CurrentDirection)
            {
                case Orientation.N:
                    CurrentDirection = Orientation.E;
                    break;
                case Orientation.S:
                    CurrentDirection = Orientation.W;
                    break;
                case Orientation.E:
                    CurrentDirection = Orientation.S;
                    break;
                case Orientation.W:
                    CurrentDirection = Orientation.N;
                    break;
            }
        }

        private void TurnLeft()
        {
            switch (CurrentDirection)
            {
                case Orientation.N:
                    CurrentDirection = Orientation.W;
                    break;
                case Orientation.S:
                    CurrentDirection = Orientation.E;
                    break;
                case Orientation.E:
                    CurrentDirection = Orientation.N;
                    break;
                case Orientation.W:
                    CurrentDirection = Orientation.S;
                    break;
            }
        }

        private void MoveRover()
        {
            switch (CurrentDirection)
            {
                case Orientation.N:
                    CurrentY++;
                    break;
                case Orientation.S:
                    CurrentY--;
                    break;
                case Orientation.E:
                    CurrentX++;
                    break;
                case Orientation.W:
                    CurrentX--;
                    break;
            }
        }

        private bool IsValidMove(Command command)
        {
            switch (command)
            {
                case Command.M:
                    return CanMove();
                case Command.L:
                    return true;
                case Command.R:
                    return true;
                default:
                    return false;
            }
        }

        private bool CanMove()
        {
            switch (CurrentDirection)
            {
                case Orientation.N:
                    return (CurrentY + 1) <= _mapSize.Item2;
                case Orientation.S:
                    return (CurrentY - 1) >= 0;
                case Orientation.E:
                    return (CurrentX + 1) <= _mapSize.Item1;
                case Orientation.W:
                    return (CurrentX - 1) >= 0;
                default:
                    return false;
            }
        }
    }
}
