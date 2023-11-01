// See https://aka.ms/new-console-template for more information

using TechnicalCase;

FootballTeam teamA = new FootballTeam();
FootballTeam teamB = new FootballTeam();

//this function adds scores for each teams correspondent matches 
void addScoresForEachTeam(FootballTeam team, int score)
{
    team.addScore(score);
}
//
List<int> compareAndRegister(FootballTeam teamA, FootballTeam teamB)
    {
        List<int> listOfMatchesTeamA = teamA.matches;
        List<int> listOfMatchesTeamB = teamB.matches;
        List<int> finalResult = new List<int>();
        int count = 0;

    
        foreach (int i in listOfMatchesTeamB)
        {
            for(int j = 0; j < listOfMatchesTeamA.Count; j++)
            {
                if (i >= listOfMatchesTeamA[j])
                {
                    count++;
                }
            
            }
           Console.WriteLine(count);
           finalResult.Add(count);
           count = 0;
        }
        return finalResult;

    }

//SAMPLE CASE 0
Console.WriteLine("Output Sample Case 0:");
addScoresForEachTeam(teamA, 1);
addScoresForEachTeam(teamA, 4);
addScoresForEachTeam(teamA, 2);
addScoresForEachTeam(teamA, 4);
addScoresForEachTeam(teamB, 3);
addScoresForEachTeam(teamB, 5);
compareAndRegister(teamA, teamB);
teamA.emptyListOfMatches();
teamB.emptyListOfMatches();
Console.WriteLine("------------------------------------");
//SAMPLE CASE 1
Console.WriteLine("Output Sample Case 1:");
addScoresForEachTeam(teamA, 2);
addScoresForEachTeam(teamA, 10);
addScoresForEachTeam(teamA, 5);
addScoresForEachTeam(teamA, 4);
addScoresForEachTeam(teamA, 8);
addScoresForEachTeam(teamB, 3);
addScoresForEachTeam(teamB, 1);
addScoresForEachTeam(teamB, 7);
addScoresForEachTeam(teamB, 8);
compareAndRegister(teamA, teamB);
teamA.emptyListOfMatches();
teamB.emptyListOfMatches();
