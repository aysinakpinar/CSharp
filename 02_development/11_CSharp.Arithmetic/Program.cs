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
