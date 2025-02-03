namespace CSharp.InterfacesBirds;

class Program
{
    static void Main(string[] args)
    {
        Penguin penguin = new Penguin();
        penguin.Fly();
        penguin.Sing();
        penguin.Eat();
        Crow crow = new Crow();
        crow.Fly();
        crow.Sing();
        crow.Eat();
        Gull gull = new Gull();
        gull.Fly();
        gull.Sing();
        gull.Eat();
    }
}
