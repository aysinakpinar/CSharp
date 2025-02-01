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
