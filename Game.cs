//Adding comments that were required for Step 7

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games
{
    public class Game
    {
        //Adding comments for Step 11
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public string Team1Score { get; set; }

        public Game() { }

        public Game (string team1, string team2, string team1score, string team2score)
        {
            Team1 = team1;
            Team2 = team2;
            Team1Score = team1score;
            Team2Score = team2score;
        }

        public override string ToString()
        {
            //Adding comments for Step 11
            return Team1 + "  (" + Team1Score + ")  ------ " + Team2 + "  (" + Team2Score +
                ") ";
        }
    }
}
