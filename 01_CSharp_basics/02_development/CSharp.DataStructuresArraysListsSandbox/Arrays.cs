namespace CSharp.DataStructuresArraysListsSandbox;
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