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
public class Sandbox
{
    public List<string> contentsOfMyPocket = new List<string>();
    public Sandbox()
    {
        contentsOfMyPocket.Add("keys");
        contentsOfMyPocket.Add("phone");
        contentsOfMyPocket.Add("fluff");
        contentsOfMyPocket.Remove("keys");
    }

    public void DisplayContents()
    {   
        {
            Console.WriteLine($"Number of the items in the list: " + contentsOfMyPocket.Count);
        }
        for (int index = 0; index < contentsOfMyPocket.Count; index++)
        {
            Console.WriteLine(contentsOfMyPocket[index]);
        }
        foreach(string item in contentsOfMyPocket)
        {
            Console.WriteLine(item);
        }
    }
}

public class Arrays
{
    string[] famousCatsSeenToday = new string[4];
    public Arrays()
    {
        famousCatsSeenToday[0] = "Puss in the Boot";
        famousCatsSeenToday[1] = "Garfield";
    }

    public void GetCats()
    {
        foreach(string cat in famousCatsSeenToday)
        {
            Console.WriteLine(cat);
        }
    }
}
public class FamousCats
{
    string[] famousCats = { "Larry", "Palmerston", "Geronimo", "Cat Stevens" };

    public void GetLCats()
    {
        string[] LCats = famousCats.Where(cat => cat[0] == 'L').ToArray();
        foreach(string cat in LCats)
        {
            Console.WriteLine(cat);
        }
    }
    public void ExclaimedCats()
    {
        string[] exclaimedCats = famousCats.Select(cat => string.Concat(cat, "!!!")).ToArray();
        foreach(string cat in exclaimedCats)
        {
            Console.WriteLine(cat);
        }
    }
}

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

