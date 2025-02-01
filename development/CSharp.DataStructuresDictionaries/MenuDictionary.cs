namespace CSharp.DataStructuresDictionaries;
class MakeMenuDictionary
{
    Dictionary<string, int> menu = new Dictionary<string, int>();
    internal void Add(string item, int price)
    {
        if(menu.ContainsKey(item))
        {
            Console.WriteLine($"{item} is in the menu. Try something else.");
        }
        else
        {
            menu.Add(item, price);
        }
    }
    internal void ChangePrice(string item, int price)
    {
        if(menu.ContainsKey(item))
        {
            menu[item] = price;
        } 
        else 
        {
            Console.WriteLine("No such thing in the menu.");
        }
    }

    internal void PriceOfItem(string item)
    {
        if(menu.ContainsKey(item))
        { 
            int price = menu[item];
            Console.WriteLine($"Price of {item} is: £{price}");
        }
        else 
        {
            Console.WriteLine("No such thing in the menu.");
        }
    }
    internal void RemoveItem(string item)
    {
        menu.Remove(item);
    }
}