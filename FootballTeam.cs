using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalCase
{
    public class FootballTeam
    {
        public List<int> matches;

        public FootballTeam() { 
            matches = new List<int>();
        }

        public void addScore(int score)
        {
            matches.Add(score);
        }

        public void emptyListOfMatches()
        {
            matches.Clear();
        }

    }
}
