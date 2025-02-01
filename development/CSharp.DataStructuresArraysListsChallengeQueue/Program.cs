namespace CSharp.DataStructuresArraysListsChallengeQueue;

class Program
{
    static void Main(string[] args)
    {
        Queue queue = new Queue();
        queue.Add("Aysin");
        queue.Add("Caner");
        queue.Add("Bora");
        queue.Add("Sermin");
        queue.State();
        queue.Next();
        queue.State();
    }
}
