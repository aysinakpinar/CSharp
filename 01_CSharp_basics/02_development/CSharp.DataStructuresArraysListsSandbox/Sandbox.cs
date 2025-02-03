namespace CSharp.DataStructuresArraysListsSandbox;
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