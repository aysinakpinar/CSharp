namespace CSharp.Strings;

class App
{
    static void Main(string[] args)
    {
        string question = "Person 1: what is the world's oldest (currently spoken) language?";
        string answer = "Person 2: Hindi";
        string questionAndAnswer = question + " " + answer;
        Console.WriteLine(questionAndAnswer);
        App appreciate = new App();
        Console.WriteLine(appreciate.Appreciate("Aysin"));
       
    }

    public string Appreciate(string name)
    {
        return "Thank you, "+name;
    }
}
