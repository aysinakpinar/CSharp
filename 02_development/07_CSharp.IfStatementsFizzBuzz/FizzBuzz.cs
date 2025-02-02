namespace CSharp.IfStatementsFizzBuzz;
static class FizzBuzz
{
    public static void Play(int number)
    {
        if(number % 3 == 0 && number % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if(number %3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (number % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else 
        {
            Console.WriteLine($"{number}");
        }

    }
}