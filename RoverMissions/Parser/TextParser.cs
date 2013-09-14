using RoverMissions.Enums;
using RoverMissions.Models;
using RoverMissions.Parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverMissions
{
    /// <summary>
    /// Reads the mission parameters for mars rovers from an ANSI or UTF-8 encoded text file (.txt)
    /// </summary>
    public class TextParser : IMissionParser
    {
        private Tuple<int, int> _mapSize;
        private ICollection<Mission> _missions;

        /// <summary>
        /// Creates a text file based parser for rover missions using the file located at the provided string.
        /// </summary>
        /// <param name="file"></param>
        public TextParser(string file)
        {
            var missions = new List<Mission>();
            var fileInfo = new FileInfo(file);
            var reader = fileInfo.OpenText();
            string line = string.Empty;
            using (reader)
            {
                line = reader.ReadLine();
                ReadMapSize(line);
                line = reader.ReadLine();
                while (line != null)
                {
                    var startPos = ReadStartPos(line);
                    line = reader.ReadLine();
                    var commands = ReadCommands(line);
                    var mission = new Mission(startPos, commands);
                    missions.Add(mission);
                    line = reader.ReadLine();
                }
            }
            _missions = missions;
        }

        /// <summary>
        /// Reads a line of commands for a rover from a string. If any commands are invalid an exception is thrown.
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private ICollection<Command> ReadCommands(string line)
        {
            if (line == null || string.IsNullOrWhiteSpace(line))
            {
                throw new ArgumentException("Text file is invalid. Rover has no commands.");
            }
            var commands = new LinkedList<Command>();
            foreach (var character in line.Trim())
            {
                var command = character.ToString();
                Command comm;
                if (!char.IsLetter(character) || !Enum.TryParse<Command>(command, true, out comm))
                {
                    throw new ArgumentException(string.Format("Text file is invalid. String {0} is not a valid command in line: {1}", command, line));
                }
                commands.AddLast(comm);
            }
            return commands;
        }

        /// <summary>
        /// Parses a start position with the given line. Checks for valid input, and throws exception otherwise.
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private GridPosition ReadStartPos(string line)
        {
            var tokens = line.Trim().Split();
            if (tokens.Length != 3)
            {
                throw new ArgumentException(string.Format("Text file is invalid. Not a valid length for start position. Line: {0}", line));
            }
            var coords = ParseCoordinates(tokens);

            // Parse the orientation. If the orientation is invalid an exception is thrown
            Orientation ori;
            if (!Enum.TryParse<Orientation>(tokens[2], true, out ori))
            {
                throw new ArgumentException(string.Format("Text file is invalid. Orientation could not be parsed. Line {0}", line));
            }
            return new GridPosition(coords.Item1, coords.Item2, ori);
        }

        private void ReadMapSize(string line)
        {
            if (line == null || string.IsNullOrWhiteSpace(line))
            {
                throw new ArgumentException("Text file is empty");
            }
            var tokens = line.Trim().Split();
            if (tokens.Length != 2)
            {
                throw new ArgumentException(string.Format("Text file is invalid. Not a valid length for map size. Line: {0}", line));
            }

            // Parse both x and y coordinates. If either one fails an exception is thrown.
            var coords = ParseCoordinates(tokens);
            _mapSize = coords;
        }

        /// <summary>
        /// Parse both x and y coordinates. If either one fails an exception is thrown.
        /// </summary>
        /// <param name="tokens"></param>
        /// <returns></returns>
        private Tuple<int, int> ParseCoordinates(string[] tokens)
        {
            int x = -1;
            int y = -1;
            if (!int.TryParse(tokens[0], out x) || !int.TryParse(tokens[1], out y))
            {
                throw new ArgumentException(string.Format("Text file is invalid. X and/or Y coordinates could not be parsed. X: {0}, Y: {1}", tokens[0], tokens[1]));
            }
            if (!IsNonNegative(x, y))
            {
                throw new ArgumentException(string.Format("Text file is invalid. Coordinates cannot be less than 0. X: {0}, Y: {1}", x, y));
            }
            if (_mapSize != null && !IsValidStart(x, y))
            {
                throw new ArgumentException(string.Format("Text file is invalid. Start position cannot exceed map parameters. X: {0}, Y: {1}", x, y));
            }
            return new Tuple<int, int>(x, y);
        }

        private bool IsValidStart(int x, int y)
        {
            return x <= _mapSize.Item1
                && y <= _mapSize.Item2;
        }

        private bool IsNonNegative(int x, int y)
        {
            return x >= 0
                && y >= 0;
        }

        public Tuple<int, int> GetMapSize()
        {
            return _mapSize;
        }

        public IEnumerable<Mission> GetMissions()
        {
            return _missions;
        }
    }
}
