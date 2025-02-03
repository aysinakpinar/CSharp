namespace CSharp.MultiClassSystems;

// Program.cs - a class that can only be used from within this Console Application
class Program {
  // this method defaults to `private` but that's OK
  static void Main(string[] args) {
    // create a new instance of Post
    Post birthday = new Post("Happy Birthday", "Conchita");
    // do something with it
    Console.WriteLine(birthday.content);
    Console.WriteLine(birthday.author);
  }
}





