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
