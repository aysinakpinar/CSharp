namespace CSharp.LoopsFizzBuzzFor;
static class FizzBuzz
{
    public static void PlayAll()
    {
    for(int i = 1; i < 101; i++) 
        {
        Console.WriteLine($"It is {Play(i)} for number {i}.");
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