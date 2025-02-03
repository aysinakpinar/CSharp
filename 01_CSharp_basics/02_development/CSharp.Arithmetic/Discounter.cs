namespace CSharp.Arithmetic;
class Discounter
{
    internal int discount;

    internal Discounter(int discount)
    {
        this.discount = discount;
    } 
    internal void ApplyTo(int amount)
    {
        Console.WriteLine(amount-(amount*discount/100));
    }
}