namespace CSharp.DataStructuresArraysListsChallengeQueue;
internal class Queue
{
    internal List<string> people = new List<string>();
    
    internal void Add(string name)
    {
        people.Add(name);
    }

    internal void Next()
    {
        if (people.Count > 0)
        {
            string firstName = people[0];
            people.Remove(firstName);
        }
        else
        {
            Console.WriteLine("The queue is empty!");
        }
    }

    internal void State()
    {
        if (people.Count > 0)
        {
            foreach(string name in people)
            {
                Console.WriteLine(name);
            }
        }
        
    }
}