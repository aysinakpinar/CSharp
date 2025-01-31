namespace CSharp.DataStructuresDictionaries;

class Program
{
    static void Main(string[] args)
    {
        MakeMenuDictinary menu = new MakeMenuDictinary();
        menu.Add("Coffee", 2);
        menu.Add("Coffee", 2);
        menu.Add("Muffin", 3);
        menu.Add("Tea", 1);
        menu.Add("Panini", 5);
        menu.ChangePrice("Coffee", 1);
        menu.PriceOfItem("Coffee");
        menu.RemoveItem("Tea");
        menu.PriceOfItem("Tea");
        Quiz gameScores = new Quiz();
        gameScores.Add("Ice", 1);
        gameScores.Add("Fire", 2);
        gameScores.Add("Earth", 3);
        gameScores.Add("Water", 4);
        gameScores.Add("Water", 5);
        gameScores.GetScore("Water");
        gameScores.ChangeScore("Water", 5);
        gameScores.GetScore("Water");
        gameScores.GetScore("Tree");
        gameScores.ChangeScore("Flower", 5);
        QuizGameScoreList gameScoresList = new QuizGameScoreList();
        gameScoresList.AddTeam("Ice");
        gameScoresList.AddTeam("Fire");
        gameScoresList.AddTeam("Earth");
        gameScoresList.AddTeam("Ice");
        gameScoresList.AddScores("Ice", 1);
        gameScoresList.AddScores("Fire", 2);
        gameScoresList.AddScores("Earth", 3);
        gameScoresList.AddScores("Ice", 4);
        gameScoresList.AddScores("Fire", 5);
        gameScoresList.AddScores("Earth", 6);
        gameScoresList.AddScores("Tree", 6);
        gameScoresList.GetTeamScores("Ice");
        gameScoresList.GetTeamScores("Fire");
        gameScoresList.GetTeamScores("Earth");
        gameScoresList.GetTeamScores("Flower");
        gameScoresList.UpdateFirstScore("Ice", 10);
        gameScoresList.GetTeamScores("Ice");




    }
}
class MakeMenuDictinary
{
    Dictionary<string, int> menu = new Dictionary<string, int>();
    internal void Add(string item, int price)
    {
        if(menu.ContainsKey(item))
        {
            Console.WriteLine($"{item} is in the menu. Try something else.");
        }
        else
        {
            menu.Add(item, price);
        }
    }
    internal void ChangePrice(string item, int price)
    {
        if(menu.ContainsKey(item))
        {
            menu[item] = price;
        } 
        else 
        {
            Console.WriteLine("No such thing in the menu.");
        }
    }

    internal void PriceOfItem(string item)
    {
        if(menu.ContainsKey(item))
        { 
            int price = menu[item];
            Console.WriteLine($"Price of {item} is: £{price}");
        }
        else 
        {
            Console.WriteLine("No such thing in the menu.");
        }
    }
    internal void RemoveItem(string item)
    {
        menu.Remove(item);
    }
}
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