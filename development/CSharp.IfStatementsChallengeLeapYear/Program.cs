namespace CSharp.IfStatementsChallengeLeapYear;

class Program {
  static void Main(string[] args) {
    LeapYear.isLeapYear(2000); // => true
    LeapYear.isLeapYear(1970); // => false
    LeapYear.isLeapYear(1900); // => false
    LeapYear.isLeapYear(1988); // => true
    LeapYear.isLeapYear(1500); // => false
  }
}

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
