namespace CSharp.InheritanceAnimal;

public class Animal
{
    public string species;
    public string Reproduce()
    {
        return $"{species}s reproduce by birth";
    }
    public string Feed()
    {
        return $"{species}s feed the offspring by milk";
    }
    public string sounds;
    public string Sound()
    {
        return $"{species}s make a sound as {sounds}";
    }
}
public class Cat : Animal
{
    public Cat(string species, string sounds)
    {
        this.sounds = sounds;
        this.species = species;
    }
}
public class Dog : Animal
{
    public Dog(string species, string sounds)
    {
        this.sounds = sounds;
        this.species = species;
    }
}
