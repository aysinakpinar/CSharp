namespace CSharp.InheritanceAnimal;

class Program
{
    static void Main(string[] args)
    {
        Cat cat = new Cat("cat","meaow");
        Console.WriteLine(cat.Reproduce());
        Console.WriteLine(cat.Feed());
        Console.WriteLine(cat.Sound());

        Dog dog = new Dog("dog","wof wof");
        Console.WriteLine(dog.Reproduce());
        Console.WriteLine(dog.Feed());
        Console.WriteLine(dog.Sound());
    }
}
