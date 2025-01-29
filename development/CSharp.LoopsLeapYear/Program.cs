namespace CSharp.IfStatementsChallengeLeapYear;

class Program {
  static void Main(string[] args) 
  {
   LeapYear.closestLeapYear(1998);
   LeapYear.closestLeapYear(1999);
   LeapYear.closestLeapYear(2000);
   LeapYear.closestLeapYear(2001);
   LeapYear.closestLeapYear(2002);
  }
}

static class LeapYear
{
    public static void allLeapYears(int starts, int ends)
    {
        for(int i = starts; i < ends + 1; i++)
        {
            if(isLeapYear(i) == true)
            {
                Console.WriteLine($"{i} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{i} isn't a leap year.");
            }
        }
    }

    public static void closestLeapYear(int year)
    {
        if(isLeapYear(year) == true)
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else if(isLeapYear(year + 1) == true)
        {
            Console.WriteLine($"{year + 1} is the closest leap year to {year}");
        }
        else if(isLeapYear(year + 2) == true && isLeapYear(year - 2) == true)
        {
            Console.WriteLine($"{year + 2} and {year - 2} are the closest leap years to {year}");
        }
         else if(isLeapYear(year - 1) == true)
        {
            Console.WriteLine($"{year - 1} is the closest leap year to {year}");
        }
    }
    internal static bool isLeapYear(int year)
    {
        if(year % 400 == 0)
        {
            return true;
        }
        else if(year % 100 == 0 && year % 400 != 0)
        {
            return false;    
        }
        else if(year % 4 == 0 && year % 100 != 0)
        {
            return true;
        } 
        else
        {
            return false;
        }
    }
}
