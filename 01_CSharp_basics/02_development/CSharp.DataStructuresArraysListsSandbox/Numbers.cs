namespace CSharp.DataStructuresArraysListsSandbox;
public class Numbers
{
    public int[] numbers = {1,2,3,4,5,6};

    public void DoubleNumbers()
    {
        int [] doubleNumbers = numbers.Select(number => number*2).ToArray();
        foreach(int number in doubleNumbers)
        {
            Console.WriteLine(number);
        }
    }
    public void DividedBySelf()
    {
        int [] dividedBySelf = numbers.Select(number=> number/number).ToArray();
        foreach(int number in dividedBySelf)
        {
            Console.WriteLine(number);
        }
    }
    public void EvenNumbers()
    {
        int [] evenNumbers = numbers.Where(number => number % 2 == 0).ToArray();
        foreach(int number in evenNumbers)
        {
            Console.WriteLine(number);
        }
    }
    public void AboveThree()
    {
        int [] aboveThree = numbers.Where(number => number > 3).ToArray();
        foreach(int number in aboveThree)
        {
            Console.WriteLine(number);
        }
    }
}