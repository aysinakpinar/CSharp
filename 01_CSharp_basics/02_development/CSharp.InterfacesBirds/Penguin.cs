namespace CSharp.InterfacesBirds;
public class Penguin : IBirdBehavours
{
    public void Fly()
    {
        Console.WriteLine("Penguins can not fly they live mostly on Land or in Water");
    }
    public void Sing()
    {
        Console.WriteLine("Penguins kind of sing");
    }
    public void Eat()
    {
        Console.WriteLine("Penguins eat fish");
    }
}