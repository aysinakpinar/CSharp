namespace CSharp.DataStructuresDictionariesRockPaperScissors;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Player One {RockPaperScissors.Play("rock", "scissors")}(e)s");
        Console.WriteLine($"Player One {RockPaperScissors.Play("rock", "paper")}(e)s");
        Console.WriteLine($"Player One {RockPaperScissors.Play("rock", "rock")}(e)s");
        Console.WriteLine($"Player One {RockPaperScissors.Play("scissors", "scissors")}(e)s");
        Console.WriteLine($"Player One {RockPaperScissors.Play("scissors", "paper")}(e)s");
        Console.WriteLine($"Player One {RockPaperScissors.Play("scissors", "rock")}(e)s");
        Console.WriteLine($"Player One {RockPaperScissors.Play("paper", "scissors")}(e)s");
        Console.WriteLine($"Player One {RockPaperScissors.Play("paper", "paper")}(e)s");
        Console.WriteLine($"Player One {RockPaperScissors.Play("paper", "rock")}(e)s");
        
    }
}
class RockPaperScissors
{
    internal static Dictionary<string, Dictionary<string, string>> rules = new Dictionary<string, Dictionary<string, string>>();
    static RockPaperScissors()
    {
        rules["rock"] = new Dictionary<string, string>
        {
            {"rock", "tie"},
            {"paper", "lose"},
            {"scissors", "win"}
        };
        rules["paper"] = new Dictionary<string, string>
        {
            {"rock", "win"},
            {"paper", "tie"},
            {"scissors", "lose"}
        };
        rules["scissors"] = new Dictionary<string, string>
        {
            {"rock", "lose"},
            {"paper", "win"},
            {"scissors", "tie"}
        };
    }
    public static string Play(string PlayerOne, string PlayerTwo)
    {
        if (rules.ContainsKey(PlayerOne) && rules[PlayerOne].ContainsKey(PlayerTwo))
        {
            return rules[PlayerOne][PlayerTwo];
        }
        else
        {
            return "Invalid Choice";
        }
    }
    
}