namespace CSharp.InterfacesBirds;
public class Gull : IBirdBehavours
{
    public void Fly()
    {
        Console.WriteLine("Gulls can fly");
    }
    public void Sing()
    {
        Console.WriteLine("Guls are very noisy singers");
    }
    public void Eat()
    {
        Console.WriteLine("Gulls love fish");
    }
}