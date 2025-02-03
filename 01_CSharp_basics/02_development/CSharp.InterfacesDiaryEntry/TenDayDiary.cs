namespace CSharp.InterfacesDiaryEntry;
public class TenDayDiary : IGenericDiary
{
    string [] entries = new string[10];
    int count = 0;
    public void AddEntry(string entry)
    {
        entries[count] = entry;
        count++;
    }
    public void RemoveEntry(int index)
    {
        for(int i = index; i<count-1; i++)
        {
            entries[i] = entries[i-1];
        }
        entries[count-1] = "";
        count--;
    }
    public string ReadEntry(int index)
    {
        return entries[index];
    }
}