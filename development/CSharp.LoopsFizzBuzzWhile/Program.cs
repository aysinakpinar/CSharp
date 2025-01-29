
namespace CSharp.LoopsFizzBuzzFor;

class Program
{
    static void Main(string[] args)
    {
        FizzBuzz.PlayAll();
    }
}

static class FizzBuzz
{
    public static void PlayAll()
    {
        int i = 1;
        while(i < 101) 
        {
        Console.WriteLine($"It is {Play(i)} for number {i}.");
        i++;
        }
    }
    internal static string Play(int number)
    {
        if(number % 3 == 0 && number % 5 == 0)
        {
            return "FizzBuzz";
        }
        else if(number %3 == 0)
        {
            return "Fizz";
        }
        else if (number % 5 == 0)
        {
            return "Buzz";
        }
        else 
        {
            return $"{number}";
        }

    }

}