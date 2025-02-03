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
