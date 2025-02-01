namespace CSharp.DataStructuresDictionaries;

class Program
{
    static void Main(string[] args)
    {
        MakeMenuDictionary menu = new MakeMenuDictionary();
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