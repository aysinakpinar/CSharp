namespace CSharp.MultiClassSystems;

// Program.cs - a class that can only be used from within this Console Application
class Program {
  // this method defaults to `private` but that's OK
  static void Main(string[] args) {
    // create a new instance of Post
    Post birthday = new Post("Happy Birthday", "Conchita");
    // do something with it
    Console.WriteLine(birthday.content);
  }
}

// Post.cs - the class defaults to `internal`
class Post {

  // fields would default to `private`
  internal string content;
  internal string author;

  // this method would default to `private`
  internal Post(string content, string author) {
    this.content = content;
    this.author = author;
  }
}



