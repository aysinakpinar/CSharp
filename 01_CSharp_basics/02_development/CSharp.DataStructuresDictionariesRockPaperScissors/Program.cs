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