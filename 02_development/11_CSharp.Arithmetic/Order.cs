namespace CSharp.Arithmetic;
class Order
{
    internal int total;

    internal Order(int total)
    {
        this.total = total;
    }

    internal void AddAmount(int amount)
    {
        total = total + amount;
    }

    internal void ApplyDiscount(int discount)
    {
        total = total - discount;
    }

    internal void GetTotal()
    {
        Console.WriteLine($"New total is £{total}.");
    }

    internal void FriendlyTotal()
    {
        Console.WriteLine($"Thanks! The total value of your order is £{total}.");
    }
}