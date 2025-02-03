namespace CSharp.MultiClassSystems;
// Post.cs - the class defaults to `internal`
class Post {

  // fields would default to `private`
    internal string content;
    internal string author;

  // this method would default to `private`
    internal Post(string content, string author) 
    {
        this.content = content;
        this.author = author;
    }
}