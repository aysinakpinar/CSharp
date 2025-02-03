namespace CSharp.DataStructuresArraysListsSandbox;
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