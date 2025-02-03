namespace CSharp.DataStructuresDictionariesRockPaperScissors;
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