namespace CSharp.StaticMethods;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Alert("HINT: This method must now return a string!"));
    }
      static string Alert() {
        return "default alert!!";
    }

    static string Alert(string message) {
        return message;
    }
}
