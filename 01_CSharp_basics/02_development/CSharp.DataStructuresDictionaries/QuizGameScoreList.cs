namespace CSharp.DataStructuresDictionaries;
class QuizGameScoreList
{
    Dictionary<string, List<int>> gameScores = new Dictionary<string, List<int>>();

    internal void AddTeam(string team)
    {
        if(!gameScores.ContainsKey(team))
        {
            gameScores[team] = new List<int>();
        }
        else
        {
            Console.WriteLine($"Team {team} is already in the game.");
        }
    }
    internal void AddScores(string team, int score)
    {
        if (gameScores.ContainsKey(team))
        {
            gameScores[team].Add(score);
        }
        else
        {
            Console.WriteLine($"There is no team as {team} in the game.");
        }
    }
    internal void GetTeamScores(string team)
    {
        if(gameScores.ContainsKey(team))
        {
            List<int> scores = gameScores[team];
            Console.WriteLine($"Team {team} scores are: {string.Join(", ", scores)}");
        }
        else
        {
            Console.WriteLine($"There is no team as {team} in the game.");
        }
    }
    
    internal void UpdateFirstScore(string team, int newScore)
    {
        if(gameScores.ContainsKey(team))
        {
            gameScores[team][0] = newScore;
        }
        else
        {
            Console.WriteLine($"There is no team as {team} in the game.");
        }
    }
}