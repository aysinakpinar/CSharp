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