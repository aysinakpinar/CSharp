namespace CSharp.MultiClassSystemsBagel;

class Program
{
    static void Main(string[] args)
    {
        Bagel bagel = new Bagel("sesame", "cheese", 2);
        bagel.getSeeds();
        bagel.getFilling();
        bagel.getPrice();
    }
}
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