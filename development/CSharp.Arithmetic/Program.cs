namespace CSharp.Arithmetic;

class Program
{
    static void Main(string[] args)
    {
        Order newOrder = new Order(300);
        newOrder.AddAmount(100);
        newOrder.ApplyDiscount(20);
        newOrder.GetTotal();
        newOrder.FriendlyTotal();
        Discounter discounter = new Discounter(10);
        discounter.ApplyTo(200);
    }
}

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
