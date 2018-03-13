using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board
    {
        private static readonly string[] board = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private static readonly string[][] WinningMoves = new[]
        {
            // rows
            new[] { "1", "2", "3" },
            new[] { "4", "5", "6" },
            new[] { "7", "8", "9" },

            // columns
            new[] { "1", "4", "7" },
            new[] { "2", "5", "8" },
            new[] { "3", "6", "9" },

            // diagonals
            new[] { "1", "5", "9" },
            new[] { "3", "5", "7" }

        };

        private readonly IDictionary<string, IList<string>> moves = new Dictionary<string, IList<string>>();

        public Board()
        {
            CurrentPlayer = "X";
            moves["X"] = new List<string>();
            moves["O"] = new List<string>();
        }

        public string CurrentPlayer {get; private set;}

        public void ChangePlayers()
        {
            CurrentPlayer = (CurrentPlayer == "X" ? "O" : "X");
        }

        public void MakeMove(string move)
        {
            SpacesInUse(CurrentPlayer, move);
            ChangePlayers();
        }

        public string[] MovesFor(string player)
        {
            return moves[player].ToArray();
        }

        public string[] AvailableMoves
        {
            get { return board.Except(MovesFor("X")).Except(MovesFor("O")).ToArray(); }
        }


        public bool SpacesInUse(string player, string move)
        {
            moves[player].Add(move);
            return AvailableMoves.Contains(move);
        }

    }
}
