namespace CSharp.InterfacesBirds;
public class Crow : IBirdBehavours
{
    public void Fly()
    {
        Console.WriteLine("Crows can fly");
    }
    public void Sing()
    {
        Console.WriteLine("Crows sing but not a song");
    }
    public void Eat()
    {
        Console.WriteLine("Crows can eat anything");
    }
}