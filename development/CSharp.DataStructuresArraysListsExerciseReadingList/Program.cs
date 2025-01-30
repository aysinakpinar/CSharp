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
internal class ReadingList
{
    string [] unread = new string [2];
    int count = 0;
    internal void Add(string newBook)
    { 
        if(count >= unread.Length)
        {
            ExpandArray();
        }
        unread[count] = newBook;
        count++;
    }
    internal void ExpandArray()
    {
        int newSize = unread.Length * 2;
        string [] newUnread = new string[newSize];
        for (int i =0; i < unread.Length; i++)
        {
            newUnread[i] = unread[i];
        }
        unread = newUnread;
    }
    internal void DisplayBooks()
    {
        foreach(string book in unread)
        {
            if (!string.IsNullOrEmpty(book))
            {
                Console.WriteLine(book);
            }
        }
    }

}