namespace CSharp.InstanceFields
{
    class Post 
    {
        static void Main(string[] args)
        {
            Post weather = new Post("The weather today is great", "Serena");
            Post holiday = new Post("Just about to head off to the Solomon Islands!", "Kevwe");
            weather.Display();
            holiday.Display();
        }
        string content;
        string author;
        Post(string content, string author)
            {
            this.content = content;
            this.author = author;
            }
        
        private void Display()
        {
            Console.WriteLine($"{content} - {author}");
        }
    }
}
