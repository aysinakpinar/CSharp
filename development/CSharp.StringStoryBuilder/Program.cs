namespace CSharp.ArithmeticStoryBuilder;

class Program
{
    static void Main(string[] args)
    {
        StoryBuilder newStory = new StoryBuilder("Hello this is the initial Plot");
        newStory.AddPlotline("Adding to the original plotline");
        newStory.GetPlot();
    }
}

class StoryBuilder
{
    string plot;
    internal StoryBuilder(string plot)
    {
        this.plot = plot;
    }

    internal void AddPlotline(string plotLine)
    {
        plot = $"{plot} {plotLine}";
    }

    internal void GetPlot()
    {
        Console.WriteLine(plot);
    }
}
