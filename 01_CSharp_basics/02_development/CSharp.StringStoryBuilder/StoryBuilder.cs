namespace CSharp.ArithmeticStoryBuilder;
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