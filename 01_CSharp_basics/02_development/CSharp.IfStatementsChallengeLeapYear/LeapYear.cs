namespace CSharp.IfStatementsChallengeLeapYear;
static class LeapYear
{
    internal static void isLeapYear(int year)
    {
        if(year % 400 == 0)
        {
            Console.WriteLine(true);
        }
        else if(year % 100 == 0 && year % 400 != 0)
        {
            Console.WriteLine(false);    
        }
        else if(year % 4 == 0 && year % 100 != 0)
        {
            Console.WriteLine(true);
        } 
        else
        {
            Console.WriteLine(false);
        }
    }
}