namespace CSharp.InterfacesDiaryEntry;
public class InfiniteDiary : IGenericDiary
{
    public List<string> entries = new List<string>();
    public void AddEntry(string entry)
    {
        entries.Add(entry);
    }
    public void RemoveEntry(int index)
    {
        string entry = entries[index];
        entries.Remove(entry);
    }
    public string ReadEntry(int index)
    {
        return entries[index];
    }
}