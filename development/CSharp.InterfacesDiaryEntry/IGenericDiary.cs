namespace CSharp.InterfacesDiaryEntry;
interface IGenericDiary
{
    void AddEntry(string entry);
    void RemoveEntry(int index);
    string ReadEntry(int index);
}