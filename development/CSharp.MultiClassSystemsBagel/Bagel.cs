namespace CSharp.MultiClassSystemsBagel;
class Bagel
{
    internal string seeds;
    internal string filling;
    internal int price;

    internal Bagel(string seeds, string filling, int price)
    {
        this.seeds = seeds;
        this.filling = filling;
        this.price = price;
    }
    internal void getSeeds()
    {
        Console.WriteLine($"There is {seeds} on the bagel.");
    }

    internal void getFilling()
    {
        Console.WriteLine($"There in {filling} in the bagel.");
    }

    internal void getPrice()
    {
        Console.WriteLine($"Bagel is £{price}.");
    }
}