namespace CSharp.InheritancePosts;

class Program
{
    static void Main(string[] args)
    {
    TextPost textPost = new TextPost("Hello world", 50);
    VideoPost videoPost = new VideoPost("Cats are dancing","/videos/dance.mp4", 101 );
    Console.WriteLine(textPost.isPopular());
    Console.WriteLine(videoPost.isPopular());
    }
}
