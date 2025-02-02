namespace CSharp.InterfacesDiaryEntry;

class Program
{
    static void Main(string[] args)
    {
        InfiniteDiary infiniteDiary = new InfiniteDiary();
        infiniteDiary.AddEntry("walk the dog");
        infiniteDiary.AddEntry("clean the house");
        infiniteDiary.AddEntry("meet friends");
        infiniteDiary.AddEntry("go to gym");
        TenDayDiary tenDayDiary = new TenDayDiary();
        tenDayDiary.AddEntry("walk the dog");
        tenDayDiary.AddEntry("clean the house");
        tenDayDiary.AddEntry("meet friends");
        tenDayDiary.AddEntry("go to gym");
        Console.WriteLine(infiniteDiary.ReadEntry(0));
        Console.WriteLine(tenDayDiary.ReadEntry(1));
        infiniteDiary.RemoveEntry(0);
        Console.WriteLine($"First element after removing {infiniteDiary.ReadEntry(0)}");

    }
}
