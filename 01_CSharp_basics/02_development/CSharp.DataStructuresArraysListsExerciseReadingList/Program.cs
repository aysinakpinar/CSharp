namespace CSharp.DataStructuresArraysListsExerciseReadingList;

class Program
{
    static void Main(string[] args)
    {
        ReadingList unreadList = new ReadingList();
        unreadList.Add("Lord of the Rings");  
        unreadList.Add("1984");
        unreadList.Add("Brave New World"); 
        unreadList.DisplayBooks();
    }
}