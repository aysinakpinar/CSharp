namespace CSharp.InheritancePosts;

class Post
{
    public int likes;
    public bool isPopular()
    {
        return this.likes > 100;
    }
}

class TextPost : Post
{
    public string content;
    public TextPost(string content, int likes)
    {
        this.content = content;
        this.likes = likes;
    }
}
class VideoPost : Post
{
    public string title;
    public string videoPath;
    public VideoPost(string title, string videoPath, int likes)
    {
        this.title = title;
        this.videoPath = videoPath;
        this.likes = likes;
    }
}