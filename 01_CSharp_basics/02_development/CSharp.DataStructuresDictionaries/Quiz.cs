namespace CSharp.DataStructuresDictionaries;
internal class Quiz
{
    Dictionary<string, int> scores = new Dictionary<string, int>();
    internal void Add(string team, int score)
    {
        if(scores.ContainsKey(team))
        {
            Console.WriteLine($"Team {team} is already in the game.");
        }
        else
        {
            scores.Add(team, score);
        }
    }
    internal void GetScore(string team)
    {
        if (scores.ContainsKey(team))
        {
            int score = scores[team];
            Console.WriteLine($"Score of team {team}: {score}");
        }
        else
        {
            Console.WriteLine($"There is no team as {team} in the game.");
        }
    }
    internal void ChangeScore(string team, int newScore)
    {
        if(scores.ContainsKey(team))
        {
            scores[team] = newScore;
        }
        else
        {
            Console.WriteLine($"There is no team as {team} in the game.");
        }
    }
}