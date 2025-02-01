namespace CSharp.DataStructuresArraysListsSandbox;

class Program
{
    static void Main(string[] args)
    {
        Sandbox contents = new Sandbox();
        Console.WriteLine($"First item in my pocket is {contents.contentsOfMyPocket[0]}");
        contents.DisplayContents();
        Arrays Cats = new Arrays();
        Cats.GetCats();
        FamousCats famousCatList = new FamousCats();
        famousCatList.GetLCats();
        famousCatList.ExclaimedCats();
        Numbers numbers = new Numbers();
        numbers.DoubleNumbers();
        numbers.DividedBySelf();
        numbers.EvenNumbers();
        numbers.AboveThree();

    }
}
